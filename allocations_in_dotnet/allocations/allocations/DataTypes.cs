namespace allocations;

public static class Datatypes
{
    public static void Run()
    {
        var cA = new ClassA { P1 = 1 };
        var sA = new StructA { P1 = 2 };
        var cB = new ClassA { P1 = 3 };
        var sB = new StructA { P1 = 4 };
    }
}


internal class ClassA
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }
    public int P4 { get; set; }
}



internal struct StructA
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }
    public int P4 { get; set; }
}