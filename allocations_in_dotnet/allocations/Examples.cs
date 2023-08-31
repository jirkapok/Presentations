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

    // compiler generated closure
    internal static IEnumerable<int> GetNumbersEnumerator()
    {
        yield return 1;
        yield return 2;
    }

    // Task vs. ValueTask
    internal static Task<int> ResolveTask()
    {
        return Task.FromResult(5);
    }

    internal static ValueTask<int> ResolveValueTask()
    {
        return ValueTask.FromResult(5);
    }
}