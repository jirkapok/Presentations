using static Calculator.ConsoleUi;

WriteResult(
    Calculate(
        ReadNumber("Enter first number:"),
        ReadNumber("Enter second number:"),
        ReadText("Enter mathematical operation (+,-,*,/): ")));

int Calculate(int first, int second, string operation) => operation switch
{
    "+" => first + second,
    "-" => first - second,
    "*" => first * second,
    "/" => first / second,
    _ => throw new NotImplementedException("Unknown mathematical operation")
};