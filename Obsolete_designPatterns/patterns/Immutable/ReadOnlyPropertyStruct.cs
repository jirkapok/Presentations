namespace patterns.Immutable;

struct ReadOnlyPropertyStruct
{
    public string Name { get; }

    // to declare this property doesn't change state
    public readonly string Capital => Name.Substring(0, 1);

    public ReadOnlyPropertyStruct(string name)
    {
        this.Name = name;
    }
}