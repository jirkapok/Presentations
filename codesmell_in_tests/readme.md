# Code smell in tests

This presentation was part of the Windows user group days 2020. Purpose of it was to show importance of tests quality and demonstrate how these smells can be improved. As usually each code smell has its own directory with source code. There are two solutions, one with source code smells and one with example solution.

> **NOTE**: The presented solutions don't represent the only solution nor lead to better or shorter code in all case.

## How to collect the code smells

* Learn from others mistakes
* Unable to calculates statistics to find "The most common mistake", there is no such tool, only static code analysis, which needs to be setup for all studied repositories
* Unable to study all repositories with all the code and merge numbers
* Picked up only what was obvious and already known (from my own experience)
* => **Ambitions not fulfilled**, only collected examples of code smells visible in source code

## Checked repositories

 To use trustful code examples i didn't base my presentation on my personal experience only. I searched for examples from real world public repositories and why not to pick up the well known?

* [dotnet runtime](https://github.com/dotnet/runtime) ([list of dotnet repositories](https://github.com/dotnet/core/blob/master/Documentation/core-repos.md))
* [Mono](https://github.com/mono/mono) - some tests written as applications
* [dotnet maui](https://github.com/dotnet/maui)
* [aspnet core](https://github.com/dotnet/aspnetcore)
* [Entity framework core](https://github.com/dotnet/efcore)
* [Chocolatey](https://github.com/chocolatey/choco)
* [xUnit](https://github.com/xunit/xunit)

## F.I.R.S.T. Expectations

Unit tests should be:

* Fast
* Isolated/Independent
* Repeatable
* Self-Validating
* Timely

## Examples

Following examples are shown in format repo:FullClassPath.

* Multiple asserts (dotnetruntime:System.Reflection.Metadata.HandleTests, dotnetruntime:System.IO.BinaryReaderTests, dotnetruntime:System.Net.WebClientTest)
  * Mono contains Assert messages with index of the assert to be able identify which test fail (mono:MonoTests.System.Windows.Forms.DateTimePickerTest)
* Test multiple things (dotnetruntime:System.IO.BinaryWriter.WriteByteCharTests)
* Usage of random (dotnetruntime:System.IO.BinaryReaderTests)
  * DateTime.Now (chocolatey:chocolatey.tests.integration.infrastructure.filesystem.DotNetFileSystemSpecs, System.Tests.DateTimeTests)
* Magic constants (dotnetruntime:System.IO.BinaryWriterTests)
  * Numeric calculations (dotnetruntime:System.Reflection.Metadata.LargeTablesAndHeapsTests)
* "IF" Conditional statements (dotnetruntime:System.Security.SecureStringTest)
* Code duplicity (dotnetruntime:System.Threading.Tasks.CancellationTokenTests)
  * Inheritance usage (mono:MonoTests.System.HttpStyleUriParserTest)

## Recommendations

* Take care of your code the same way you do with your production code
* Refactor the code together when changing production code
* The Unit tests are also written in Object oriented language, use it

## Side notes

* To be able compile .net runtime `Python` is needed
* [Behavior driven development](https://en.wikipedia.org/wiki/Behavior-driven_development) is used in Chocolatey repo, implemented using [TinySpec.NUnit](https://www.nuget.org/packages/TinySpec.NUnit)

## Links

* [The art of unit testing](https://www.amazon.com/Art-Unit-Testing-examples/dp/1617290890/)
* [xUnit Test Patterns Refactoring Code](https://www.amazon.com/xUnit-Test-Patterns-Refactoring-Code/dp/0131495054/)