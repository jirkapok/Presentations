namespace allocations;

public class BoxingExamples
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
}