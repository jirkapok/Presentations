using System.Text;

namespace allocations;

public class StringExamples
{
    public static string String_Concatenation()
    {
        return "ab" + 9;
    }

    public static string String_Const()
    {
        return "abc";
    }

    public static string StringBuilder()
    {
        var builder = new StringBuilder();
        builder.Append("abc");
        return builder.ToString();
    }
}