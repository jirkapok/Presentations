using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace allocations;

public static class Examples
{
    // the same example applies to input parameters
    public static object Boxing()
    {
        int source = Random.Shared.Next(0, 10000);
        // hidden boxing captured by Heap allocation viewer
        // ReSharper disable once HeapView.BoxingAllocation
        return source;
    }

    public static int NoBoxing()
    {
        int source = Random.Shared.Next(0, 10000);
        return source;
    }

    public static void ArrayOnStack()
    {
        int length = 10;
        Span<int> arrayOnStack = stackalloc int[length];

        for (var i = 0; i < length; i++)
        {
            arrayOnStack[i] = i;
        }
    }


    public static void Create_Class()
    {
        var cA = new ClassA { P1 = 1 };
    }

    public static void Create_Struct()
    {
        var sA = new StructA { P1 = 2 };
    }

    public static void Create_Record()
    {
        var cA = new RecordA { P1 = 1 };
    }

    public static void Create_RecordStruct()
    {
        var sA = new RecordStructA { P1 = 2 };
    }

    // parameters are on stack, so still there are no allocations
    public static void Call_ByReference(ref StructA source)
    {
        source.P1 = 2;
    }

    private static readonly int[] numbers = new[] { 1, 3, 5, 7, 9 };

    public static int Closure()
    {
        const int source = 1; // constant is inlined to the lambda
        var result = numbers.Count(n => n > source);
        return result;
    }

    public static int Closure_WithCatchedParameter()
    {
        int source = 1;
        var result = numbers.Count(n => n > source);
        return result;
    }

    // compiler generated closure
    public static IEnumerable<int> CreateEnumerator()
    {
        yield return 1;
        yield return 2;
    }

    public static int[] Create_Array()
    {
        // extract to static readonly field to prevent allocation every time
        return new[] { 3, 4 };
    }

    public static int[] Slice_ToArray()
    {
        var result = numbers.Skip(1).Take(3)
            .ToArray();
        return result;
    }

    public static Span<int> Slice_Span()
    {
        // In older .net see ArraySegment or StringSegment classes
        var result = numbers.AsSpan()
            .Slice(1, 3);
        return result;
    }

    // TODO improve string examples
    public static string String_Concatenation()
    {
        return "ab" + 9;
    }

    public static string String_Const()
    {
        return "abc";
    }

    public static string StringBuilder()
    {
        var builder = new StringBuilder();
        builder.Append("abc");
        return builder.ToString();
    }

    // Task vs. ValueTask
    public static Task<int> ResolveTask()
    {
        // class
        return new Task<int>(() => 5);
    }

    public static ValueTask<int> ResolveValueTask()
    {
        // structure
        return new ValueTask<int>(5);
    }

    // Tuple vs. ValueTuple
    public static Tuple<int, int> CreateTuple()
    {
        return new Tuple<int, int>(5, 6);
    }

    public static ValueTuple<int, int> CreateValueTuple()
    {
        return new ValueTuple<int, int>(7, 8);
    }

    private static List<LargeObject> largeObjects = new List<LargeObject>();
    
    public static void Allocate_On_LargeObjectHeap()
    {
        for (int index = 0; index < 200; index++)
        {
            largeObjects.Add(new LargeObject());

            if (index > 100)
            {
                var maxIndex = largeObjects.Count - 1;
                largeObjects.RemoveAt(Random.Shared.Next(0, maxIndex));
            }
        }
    }
}