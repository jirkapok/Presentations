namespace allocations;

public class ValueTypes
{
    // Task vs. ValueTask
    public static Task<int> ResolveTask()
    {
        // class
        return new Task<int>(() => 5);
    }

    public static ValueTask<int> ResolveValueTask()
    {
        // structure
        return new ValueTask<int>(5);
    }

    // Tuple vs. ValueTuple
    public static Tuple<int, int> CreateTuple()
    {
        return new Tuple<int, int>(5, 6);
    }

    public static ValueTuple<int, int> CreateValueTuple()
    {
        return new ValueTuple<int, int>(7, 8);
    }
}