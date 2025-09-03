# Functional C#

## Definition of C# z WIKI
* https://en.wikipedia.org/wiki/C_Sharp_(programming_language)
* Multi-paradigm: structured, imperative, object-oriented, event-driven, task-driven, functional, generic, reflective, concurrent
* https://www.amazon.com/Functional-Programming-write-better-code/dp/1617293954


## Already build in
* Delegates and lambdas (C# 3)
```csharp
persons.Where(p => p.IsRetired)
```

* Static usings (C# 6)
```csharp
using static System.Math;
double result = Pow(2, 3);
```

* Nonnullable (C# 8)
```csharp
string? nickname = null;
```

* Immutables (record C# 9+)
```csharp
public record Person(string Name, DateOnly BirthDate);
```

* Pattern matching (C# 7-11)
```csharp
  if (obj is string s) ...
  if (person is { Age: > 18, Name: var n }) ...
  var result = shape switch
  {
  Circle c => "circle",
  _ => "Unknown shape"
  }
```

## The good parts
* Linq lambas (Dotnet 3.5 2007) - tragedie představená v roce 2017: lokální funkce
* Exception handling (Try object)
* Result Type (https://dotnet.github.io/dotNext/features/core/result.html)
* Option instead of Null (https://dotnet.github.io/dotNext/features/core/optional.html)
* Discriminated unions (Most awaited feature) https://www.youtube.com/watch?v=tD46WVJ2h9I&ab_channel=NickChapsas


## Examples Implementations
* Used language-ext and OneOf nugets
* Others: Functional.DotNet, Funcky, FunCs, Fambda, Farity or other exotic implementations like FuncSharp


## Examples based on following sources
  * [FuncSharp library](https://github.com/MewsSystems/FuncSharp)
  * [The New Option and Result Types of C#](https://www.youtube.com/watch?v=aksjZkCbIWA)
  * [Result pattern in medatr](https://goatreview.com/improving-error-handling-result-pattern-mediatr/)
  * [Mews made me a better developer](https://developers.mews.com/mews-made-me-a-better-developer/)