namespace allocations;

public static class Examples
{
    public static void TestBoxing()
    {
        var result = BoxNumber();
    }

    private static object BoxNumber()
    {
        int source = Random.Shared.Next(0, 10000);
        // hidden boxing captured by Heap allocation viewer
        // ReSharper disable once HeapView.BoxingAllocation
        return source;
    }

    public static void Call_ClassStruct()
    {
        // take snapshot, see locals to observe current stack frame initial values of the variables
        var cA = new ClassA { P1 = 1 };
        var sA = new StructA { P1 = 2 };
        var cB = new ClassA { P1 = 3 };
        var sB = new StructA { P1 = 4 };
        // take second snapshot and observe heap
    }

    public static void Call_Records()
    {
        // take snapshot, see locals to observe current stack frame initial values of the variables
        var cA = new RecordA { P1 = 1 };
        var sA = new RecordStructA { P1 = 2 };
        var cB = new RecordA { P1 = 3 };
        var sB = new RecordStructA { P1 = 4 };
        // take second snapshot and observe heap
    }
}