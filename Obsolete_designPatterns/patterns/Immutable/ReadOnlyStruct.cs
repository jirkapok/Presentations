using System.Runtime.CompilerServices;

namespace patterns.Immutable;

readonly struct ReadOnlyStruct
{
    // adding readonly here is ok, but makes no sense
    public string Name { get; }

    public ReadOnlyStruct(string name)
    {
        this.Name = name;
    }
}