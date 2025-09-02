using NUnit.Framework;

namespace FunctionalCsharp;

[TestFixture]
public class SetupTestTests : ApiTests
{
    [Test]
    public void CallApi_Returns_Items()
    {
        CallApiTest(
            arrange: () => 7,
            act: a => a,
            assert: r => Assert.That(r, Is.EqualTo(7)));
    }
}

public class ApiTests
{
    // Imagine the type gymnastics with more parameters for the arrange, act and assert methods...
    protected void CallApiTest<TParam, TResult>(Func<TParam> arrange, Func<TParam, TResult> act, Action<TResult> assert)
    {
        var toProcess = arrange();
        var result = act(toProcess);
        assert(result);
    }
}