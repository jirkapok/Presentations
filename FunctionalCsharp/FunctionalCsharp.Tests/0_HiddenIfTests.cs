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
        var result = FormatItemsCount(Option<int>.Some(7)); // implicit conversion to Either<string, Option<int>>

        Assert.That(result, Is.EqualTo("Items 9"));
    }

    // How many tests do i need for this method?
    private static string FormatItemsCount(Either<string, Option<int>> count)
    {
        var offset = 2;

        return count
            .Match(
                Right: r => r,
                Left: l => int.Parse(l))
            .Match(
                Some: v => $"Items {v + offset}", // allocation
                None: () => "No items");
    }
}