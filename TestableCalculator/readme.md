# Test-able calculator

This example shows legacy console application, which source code contains no tests and is not testable. It is hard to maintain or extend. We will use refactoring techniques to make it testable using TDD principles. We will result in well tested code and structured OOP code, which is easy to modify.
It is strongly recommended to have a look at repository history, how the solution was created.

This code was inspired by following video:  http://channel9.msdn.com/blogs/mtaulty/prism--silverlight-part-1-taking-sketched-code-towards-unity

Notes:

* First refactoring is critical, we don’t have tests yet
* Allow access internal members by adding InternalsVisibleTo(„Tests“)
* Extract only necessary code to internal static methods
* Best practice is to avoid „public static“ (e.g. SingleTon, Service locator)
* Validate „Test Coverage“ (e.g. using JetBrains dotCover) after each change

## Tasks

### 1. Fix a bug

1. Add Tests project
2. Add InternalsVisible to the Calculator project and add reference to the Tests project
3. Use Extract method refactoring to made the the Add method test able
4. Added test to fix the add method and fix the method
5. Use Extract class refactoring to move Add method from Program class to Mathematics class

### 2. Add new feature to support "substract" operation

1. Move the Console.WriteLine out of the switch statement (to local variable, split declaration and assingment and move variable to outer scope refactorings)
2. Use extact method to isolate the switch statement to calculate method and update tests
3. Refactor the Calculate method to simplify the code
4. Moved Calculate method to new CalculatorService class using extract class refactoring

### 3. Replace the user interface by another one

1. TODO
