namespace Calculator;

public static class ConsoleUi
{
    public static int ReadNumber(string message)
    {
        var text = ReadText(message);
        return int.Parse(text);
    }

    public static string? ReadText(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    public static void WriteResult(int i)
    {
        Console.WriteLine($"Result is: {i}");
    }
}