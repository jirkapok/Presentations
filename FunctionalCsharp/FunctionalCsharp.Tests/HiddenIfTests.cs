using LanguageExt;
using NUnit.Framework;

// Příklady:
// * Když nevíš, tak Option
// * Coproduct


namespace FunctionalCsharp;

[TestFixture]
public class HiddenIfTests
{
    private const int valueToCheck = 7;

    [Test]
    public void Conditional_resolves_value()
    {
        var result = FormatItemsCount(valueToCheck);

        Assert.That(result, Is.EqualTo("Items 7"));
    }

    private static string FormatItemsCount(int count)
    {
        return Either<string, int>.Right(count)
            .Match(
                Right: Option<int>.Some,
                Left: _ => Option<int>.None)
            .Match(
                Some: v => $"Items {v}",
                None: () => "No items");
    }
}