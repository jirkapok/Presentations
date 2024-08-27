WriteResult(
    Calculate(
        ReadNumber("Enter first number:"),
        ReadNumber("Enter second number:"),
        ReadText("Enter mathematical operation (+,-,*,/): ")));

// TODO write loop around the calculation

// TODO refactor to not throwing exception
int Calculate(int first, int second, string operation) => operation switch
{
    "+" => first + second,
    "-" => first - second,
    "*" => first * second,
    "/" => first / second,
    _ => throw new NotImplementedException("Unknown mathematical operation")
};

int ReadNumber(string message)
{
    var text = ReadText(message);
    return int.Parse(text);
}

string? ReadText(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

void WriteResult(int i)
{
    Console.WriteLine($"Result is: {i}");
}