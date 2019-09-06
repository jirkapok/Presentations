# Bad things in C# since version 7.0

Purpose of this presentation is to balance positive opinions around new things introduced in latest versions of C# (written in 8/2019, e.g. C# 6.0-8.0 versions). I created it becauses only presentations how new features are available, which isn't usually true. Not all features are listed, because not all are bad, and also the listed aren't listed to only be "the dard side", there are always gray colors between white and black. The features have good motivation, why they were introduced, but the bad think is, when they are missused.

> `NOTE`: Read this presentation as alternative opinions only.

> `MOTO` :  **Improve productivity when writing C#. Write more concise code that is also more readable.**

## Discused topics:

* Syntactic sugar
* String interpolations
* Null-conditional operators
* Local functions
* Exception filters
* Tuples
* Out variables
* Default interface members

## Results

* They aren't bad, but may reslt in code harder to read and dangerous.
* They have concreate usage and should be used carefully to prevent misuse.
* Usually they show wrong OOP design.

## Links

* https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6
* https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7
* https://github.com/dotnet/csharplang
* https://www.tiobe.com/tiobe-index/
* https://insights.stackoverflow.com/trends
* [Clean cod book at Amazon](https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882)
* https://asizikov.github.io/2016/04/15/thoughts-on-local-functions/
* https://devblogs.microsoft.com/premier-developer/dissecting-the-local-functions-in-c-7/
* https://docs.microsoft.com/en-us/dotnet/csharp/local-functions-vs-lambdas
* https://www.davidhayden.me/blog/tuples-csharp-7-visual-studio-2017