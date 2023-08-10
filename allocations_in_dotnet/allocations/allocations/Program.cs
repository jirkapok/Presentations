using allocations;

// Run benchmarks only
// BenchmarkRunner.Run<Boxing>();

// debug examples
// new Boxing().TestBoxing();
Examples.Call_ClassStruct();
Examples.Call_Records();


// TODO add more examples:
// compare: class, struct, class record, struct record ( > C# 10)
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records
// pointers
// array allocations
// string allocations
// compare large object heap and pinned objects
// typical scenarios

// Based on following:
// stack vs. heap https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet
// What are the limits of stack? https://stackoverflow.com/questions/823724/stack-capacity-in-c-sharp
// https://benchmarkdotnet.org/
// https://plugins.jetbrains.com/plugin/9223-heap-allocations-viewer
// https://www.youtube.com/watch?v=B2yOjLyEZk0
// https://youtu.be/jONSIhMST9E