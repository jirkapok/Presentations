using System.Threading.Tasks;

namespace allocations;

[ShortRunJob]
[MemoryDiagnoser]
public class AllocationTests
{
    [Benchmark()]
    public void Boxing()
    {
        Examples.Boxing();
    }

    [Benchmark()]
    public void NoBoxing()
    {
        Examples.NoBoxing();
    }

    [Benchmark()]
    public void Create_Class()
    {
        Examples.Create_Class();
    }

    [Benchmark()]
    public void Create_Struct()
    {
        Examples.Create_Struct();
    }

    [Benchmark()]
    public void Create_Record()
    {
        Examples.Create_Record();
    }

    [Benchmark()]
    public void Create_RecordStruct()
    {
        Examples.Create_RecordStruct();
    }

    [Benchmark()]
    public void Call_ByReference()
    {
        var source = new StructA();
        Examples.Call_ByReference(ref source);
    }

    [Benchmark()]
    public void GetEnumerator()
    {
        var result = Examples.GetNumbersEnumerator();
    }

    [Benchmark()]
    public async Task ResolveTask()
    {
        var task = Examples.ResolveTask();
        var result =  await task;
    }


    [Benchmark()]
    public async Task ResolveValueTask()
    {
        var task = Examples.ResolveValueTask();
        var result = await task;
    }
}
