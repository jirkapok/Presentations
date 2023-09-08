using System.Threading.Tasks;

namespace allocations;

[ShortRunJob]
[MemoryDiagnoser]
public class AllocationTests
{
    //[Benchmark()]
    public void Boxing()
    {
        Examples.Boxing();
    }

    //[Benchmark()]
    public void NoBoxing()
    {
        Examples.NoBoxing();
    }

    //[Benchmark()]
    public void Create_Class()
    {
        Examples.Create_Class();
    }

    //[Benchmark()]
    public void Create_Struct()
    {
        Examples.Create_Struct();
    }

    //[Benchmark()]
    public void Create_Record()
    {
        Examples.Create_Record();
    }

    //[Benchmark()]
    public void Create_RecordStruct()
    {
        Examples.Create_RecordStruct();
    }

    //[Benchmark()]
    public void Call_ByReference()
    {
        var source = new StructA();
        Examples.Call_ByReference(ref source);
    }
    
    [Benchmark()]
    public void Closure()
    {
        var result = Examples.Closure();
    }
    
    [Benchmark()]
    public void Closure_WithCatchedParameter()
    {
        var result = Examples.Closure_WithCatchedParameter();
    }

    //[Benchmark()]
    public void CreateArray()
    {
        var result = Examples.Create_Array();
    }
    
    //[Benchmark()]
    public void CreateEnumerator()
    {
        var result = Examples.CreateEnumerator();
    }
    
    //[Benchmark()]
    public void String_Concatenation()
    {
        var result = Examples.String_Concatenation();
    }
    
    //[Benchmark()]
    public void String_Const()
    {
        var result = Examples.String_Const();
    }
    
    //[Benchmark()]
    public void StringBuilder()
    {
        var result = Examples.StringBuilder();
    }

    //[Benchmark()] // somehow Benchmark freezes on this
    public async Task ResolveTask()
    {
        var task = Examples.ResolveTask();
        var result =  await task;
    }

    //[Benchmark()]
    public async Task ResolveValueTask()
    {
        var task = Examples.ResolveValueTask();
        var result = await task;
    }
}
