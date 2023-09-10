namespace allocations;

public class CallExamples
{
    // parameters are on stack, so still there are no allocations
    public static void Call_ByReference(ref StructA source)
    {
        source.P1 = 2;
    }

    internal static readonly int[] numbers = new[] { 1, 3, 5, 7, 9 };

    public static int Closure()
    {
        const int source = 1; // constant is inlined to the lambda
        var result = numbers.Count(n => n > source);
        return result;
    }

    public static int Closure_WithCatchedParameter()
    {
        int source = 1;
        var result = numbers.Count(n => n > source);
        return result;
    }
}