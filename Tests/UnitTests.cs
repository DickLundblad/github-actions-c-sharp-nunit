using NUnit.Framework;
namespace MyTests;

[TestFixture]
public class UnitTests
{
    [Test]
    public void DummyTest()
    {
        /* `Assert` is a class typically used in unit testing frameworks to verify conditions in your
        code. In this context, `Assert.True(true)` is verifying that the condition `true` is indeed
        true, which is a way to ensure that a certain expected behavior is met during testing. */
        var myString = "Hello";
        TestContext.Out.WriteLine("Hello from test"); 
        Assert.That(myString, Is.EquivalentTo("Hello"));
    }
}