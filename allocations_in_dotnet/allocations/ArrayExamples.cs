namespace allocations;

public class ArrayExamples
{
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
        var result = CallExamples.numbers.Skip(1).Take(3)
            .ToArray();
        return result;
    }

    public static Span<int> Slice_Span()
    {
        // In older .net see ArraySegment or StringSegment classes
        var result = CallExamples.numbers.AsSpan()
            .Slice(1, 3);
        return result;
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
}