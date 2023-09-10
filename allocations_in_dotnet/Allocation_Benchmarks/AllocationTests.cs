using allocations;
using BenchmarkDotNet.Attributes;

namespace Allocation_Benchmarks;

[ShortRunJob]
[MemoryDiagnoser]
public class AllocationTests
{
    //[Benchmark()]
    public void Boxing()
    {
        BoxingExamples.Boxing();
    }

    //[Benchmark()]
    public void NoBoxing()
    {
        BoxingExamples.NoBoxing();
    }
    
    // [Benchmark()]
    public void ArrayOnStack()
    {
        ArrayExamples.ArrayOnStack();
    }

    //[Benchmark()]
    public void Create_Class()
    {
        ObjectCreationExamples.Create_Class();
    }

    //[Benchmark()]
    public void Create_Struct()
    {
        ObjectCreationExamples.Create_Struct();
    }

    //[Benchmark()]
    public void Create_Record()
    {
        ObjectCreationExamples.Create_Record();
    }

    //[Benchmark()]
    public void Create_RecordStruct()
    {
        ObjectCreationExamples.Create_RecordStruct();
    }

    //[Benchmark()]
    public void Call_ByReference()
    {
        var source = new StructA();
        CallExamples.Call_ByReference(ref source);
    }
    
    //[Benchmark()]
    public void Closure()
    {
        var result = CallExamples.Closure();
    }
    
    //[Benchmark()]
    public void Closure_WithCatchedParameter()
    {
        var result = CallExamples.Closure_WithCatchedParameter();
    }

    //[Benchmark()]
    public void CreateArray()
    {
        var result = ArrayExamples.Create_Array();
    }
    
    //[Benchmark()]
    public void CreateEnumerator()
    {
        var result = ArrayExamples.CreateEnumerator();
    }
    
    [Benchmark()]
    public void Slice_ToArray()
    {
        var result = ArrayExamples.Slice_ToArray();
    }
    
    [Benchmark()]
    public void Slice_Span()
    {
        var result = ArrayExamples.Slice_Span();
    }
    
    //[Benchmark()]
    public void String_Concatenation()
    {
        var result = StringExamples.String_Concatenation();
    }
    
    //[Benchmark()]
    public void String_Const()
    {
        var result = StringExamples.String_Const();
    }
    
    //[Benchmark()]
    public void StringBuilder()
    {
        var result = StringExamples.StringBuilder();
    }

    //[Benchmark()] // somehow Benchmark freezes on this
    public async Task ResolveTask()
    {
        var task = ValueTypes.ResolveTask();
        var result =  await task;
    }

    //[Benchmark()]
    public async Task ResolveValueTask()
    {
        var task = ValueTypes.ResolveValueTask();
        var result = await task;
    }
}
