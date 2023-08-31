# Allocations in .net

* Run the example and take memory snapshot at beginning and end of each method and compare them
* This example uses Benchmark .net nuget library for .net performance measures
* Resharper or Rider plugin: <https://github.com/controlflow/resharper-heapview>

## Examples

1. Compare boxing of input/output parameters
2. Compare value/reference types


## Takeaways

* Always measure before refactoring
* Allocation is cheap, what is expensive is garbage collection
* Platform matters, you need to know what compiler generates
* 


// TODO add more examples:
// pointers
// array allocations
// string allocations
// compare large object heap and pinned objects
// typical scenarios
// System.Tupe vs. System.ValueTuple

## Based on following resources
* https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records
* stack vs. heap https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet
* What are the limits of stack? https://stackoverflow.com/questions/823724/stack-capacity-in-c-sharp
* https://benchmarkdotnet.org/
* https://plugins.jetbrains.com/plugin/9223-heap-allocations-viewer
* https://www.youtube.com/watch?v=B2yOjLyEZk0
* https://youtu.be/jONSIhMST9E
* https://youtu.be/H6BRyRAZEd4
* https://youtu.be/nK54s84xRRs
