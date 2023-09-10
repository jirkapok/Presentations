using System.Text;

namespace allocations;

public static class Examples
{
    // the same example applies to input parameters
    internal static object Boxing()
    {
        int source = Random.Shared.Next(0, 10000);
        // hidden boxing captured by Heap allocation viewer
        // ReSharper disable once HeapView.BoxingAllocation
        return source;
    }

    internal static int NoBoxing()
    {
        int source = Random.Shared.Next(0, 10000);
        return source;
    }
    
    internal static void ArrayOnStack()
    {
        int length = 10;
        Span<int> arrayOnStack = stackalloc int[length];
        
        for (var i = 0; i < length; i++)
        {
            arrayOnStack[i] = i;
        }
    }
    

    internal static void Create_Class()
    {
        var cA = new ClassA { P1 = 1 };
    }

    internal static void Create_Struct()
    {
        var sA = new StructA { P1 = 2 };
    }

    internal static void Create_Record()
    {
        var cA = new RecordA { P1 = 1 };
    }

    internal static void Create_RecordStruct()
    {
        var sA = new RecordStructA { P1 = 2 };
    }

    // parameters are on stack, so still there are no allocations
    internal static void Call_ByReference(ref StructA source)
    {
        source.P1 = 2;
    }

    private static readonly int[] numbers = new[] { 1, 3, 5, 7, 9 }; 

    internal static int Closure()
    {
        const int source = 1; // constant is inlined to the lambda
        var result = numbers.Count(n => n > source);
        return result;
    }
    
    internal static int Closure_WithCatchedParameter()
    {
        int source = 1;
        var result = numbers.Count(n => n > source);
        return result;
    }
    
    // compiler generated closure
    internal static IEnumerable<int> CreateEnumerator()
    {
        yield return 1;
        yield return 2;
    }

    internal static int[] Create_Array()
    {
        // extract to static readonly field to prevent allocation every time
        return new[] { 3, 4 };
    }
    
    internal static int[] Slice_ToArray()
    {
        var result = numbers.Skip(1).Take(3)
            .ToArray();
        return result;
    }
    
    internal static Span<int> Slice_Span()
    {
        // In older .net see ArraySegment or StringSegment classes
        var result =  numbers.AsSpan()
            .Slice(1, 3);
        return result;
    }
    
    // TODO improve string examples
    internal static string String_Concatenation()
    {
        return "ab" + 9;
    }
    
    internal static string String_Const()
    {
        return "abc";
    }
    
    internal static string StringBuilder()
    {
        var builder = new StringBuilder();
        builder.Append("abc");
        return builder.ToString();
    }

    // Task vs. ValueTask
    internal static Task<int> ResolveTask()
    {
        return new Task<int>(() => 5);
    }

    internal static ValueTask<int> ResolveValueTask()
    {
        return new ValueTask<int>(5);
    }

    // Tuple vs. ValueTuple
    internal static Tuple<int, int> CreateTuple()
    {
        return new Tuple<int, int>(5, 6);
    }

    internal static ValueTuple<int, int> CreateValueTuple()
    {
        return new ValueTuple<int, int>(7, 8);
    }
    
    
}