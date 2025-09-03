using LanguageExt;
using NUnit.Framework;

// Příklady:
// * Coproduct

namespace FunctionalCsharp;

[TestFixture]
public class HiddenIfTests
{
    [Test]
    public void Conditional_resolves_value()
    {
        var items = Either<string, int>.Right(7);
        var result = FormatItemsCount(items);

        Assert.That(result, Is.EqualTo("Items 7"));
    }

    // How many tests do i need for this method?
    private static string FormatItemsCount(Either<string, int> count)
    {
        var offset = 2;

        return count
            .Match(
                Right: Option<int>.Some,
                Left: s => int.Parse(s))
            .Match(
                Some: v => $"Items {v + offset}", // allocation
                None: () => "No items");
    }
}