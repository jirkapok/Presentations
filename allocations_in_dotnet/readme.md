# Allocations in .net

* Run the example and take memory snapshot at beginning and end of each method and compare them
* This example uses Benchmark .net <https://benchmarkdotnet.org/> nuget library for .net performance measures
* Resharper or Rider Allocation viewer plugin: <https://github.com/controlflow/resharper-heapview>, (<https://plugins.jetbrains.com/plugin/9223-heap-allocations-viewer>)
* Use <https://sharplab.io/> to see generated code
* Useful VS or Rider views:
    * IL view
    * Use memory view

> This presentation is an excuse, dedicated to my students who heard from me through the years a lot of lies.

## Questions

1. Are value types always on stack and reference types on the heap?
2. How many heaps do we have in .net?
3. How large is the stack in .net?
4. Does the local variable survive till end of a method?
5. There is one dedicated thread for GC?
6. When does the GC collection occurs?
7. What is the priority of GC thread?

## Examples = My corrected misunderstandings

1. Allocations are expensive - No, expensive is Garbage collection
   * Allocation is move pointer of next free space after the newly allocated object
   * Large object allocation is expensive, because CLR guaranties its cleared.
   * GC does not count references to an object, it searches unreachable object from the roots
   * Generations try to prevent memory fragmentation
   * There is a difference between Server and Client GC, ephemeral segment size
   * We have more heaps in .net (GC generations, + e.g. large objects/85 KB heap + pinned objects (.net 5+)),
     (Usually people mention 3x heap for each generation - not mentioned in the documentation)
   * Understand that stack has its limitations (max. size 1 MB by default, e.g number of frames)
   * Large object heap doesnt compact the memory, because it is performance hit
   * LOH and generation 2 are collected together
2. Value types are always on stack
    * Static members are on heap, because they need to be reachable from everywhere, roots from beginning,
      since they are known and we may organize the memory
    * Compare boxing of input/output parameters
    * They are part of reference types
    * Call by reference/value
3. The type is not always what you thing
    * Compare value/reference types
    * String and arrays are reference types
    * Tuple/ValueTuple, Task/ValueTask
4. Closures are optimized
    * Method inside method or lambda
    * Captured local variable as state create 

## Takeaways

* Always measure before refactoring
* Think about garbage collections, because Allocation is cheap
* Platform matters, you need to know what compiler generates, how your app is configured
* Allocate a pool of large objects that you reuse instead of allocating temporary ones

// TODO add more examples:
// compare large object heap and pinned objects
* TODO max number of stack frames before stack overflow?


## Based on following resources

* stack vs. heap: https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet
* Stack vs. heap: <https://youtu.be/5OJRqkYbK-4>
* Stack by Scot Hanselmann: <https://youtu.be/03pp6cz8lWo>
* What are the limits of stack? https://stackoverflow.com/questions/823724/stack-capacity-in-c-sharp
* Closures: <https://youtu.be/h3MsnBRqzcY>
* Records: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records
* Span: <https://youtu.be/MGCNS6s6e5o>
* Where are value types allocated: <https://youtu.be/jONSIhMST9E>
* stackallock: <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/stackalloc>
* How GC works: <https://youtu.be/BeuNvhd1L_g>
* Server GC: <https://youtu.be/y7FTxAqExyU>
* Change GD behavior (heap count): <https://learn.microsoft.com/en-us/dotnet/core/runtime-config/garbage-collector>
* Large object heap: <https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/large-object-heap>

* Dispose pattern: <https://youtu.be/CV5UlcfFls4>
* Understanding GC: <https://stackoverflow.com/questions/17130382/understanding-garbage-collection-in-net/17131389#17131389>

* https://www.youtube.com/watch?v=B2yOjLyEZk0
* https://youtu.be/H6BRyRAZEd4
* https://youtu.be/nK54s84xRRs

  