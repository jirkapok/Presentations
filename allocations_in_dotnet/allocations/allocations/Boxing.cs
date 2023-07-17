namespace allocations;

[ShortRunJob]
[MemoryDiagnoser]
public class Boxing
{
    [Benchmark()]
    public void TestBoxing()
    {
        var result = BoxNumber();
    }

    private static object BoxNumber()
    {
        object source = Random.Shared.Next(0, 10000);
        // hidden boxing captured by Heap allocation viewer
        // ReSharper disable once HeapView.BoxingAllocation
        return source;
    }
}
