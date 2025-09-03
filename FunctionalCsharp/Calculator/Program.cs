using static Calculator.ConsoleUi;

WriteResult(
    Calculate(
        () => ReadNumber("Enter first number:"),
        () => ReadNumber("Enter second number:"),
        () => ReadText("Enter mathematical operation (+,-,*,/): ")));

int Calculate(Func<int> getFirst, Func<int> getSecond, Func<string> getOperation) => getOperation() switch
{
    "+" => getFirst() + getSecond(),
    "-" => getFirst() - getSecond(),
    "*" => getFirst() * getSecond(),
    "/" => getFirst() / getSecond(),
    _ => throw new NotImplementedException("Unknown mathematical operation")
};