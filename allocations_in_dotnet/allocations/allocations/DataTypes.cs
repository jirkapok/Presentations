namespace allocations;


internal class ClassA
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }
}

internal struct StructA
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }
}

internal record RecordA
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }
}

internal record struct RecordStructA
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }
}