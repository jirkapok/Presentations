namespace allocations;

[ShortRunJob]
[MemoryDiagnoser]
public class Boxing
{
    [Benchmark()]
    public void TestBoxing()
    {
        Examples.TestBoxing();
    }
}
