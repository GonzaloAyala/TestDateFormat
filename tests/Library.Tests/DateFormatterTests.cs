namespace Library.Tests;
using TestDateFormat;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestExpectedFormat()
    {
        string input = "03/02/1994";
        var result = DateFormatter.ChangeFormat(input);
        Assert.That(result, Is.EqualTo("1994-02-03"));
    }

    [Test]
    public void TestIsEmptyString()
    {
        string input = "";
        var result = DateFormatter.ChangeFormat(input);
        Assert.That(result, Is.EqualTo(""));
    }
        [Test]
    public void TestInvalidDay()
    {
        string input = "33/02/1994";
        var result = DateFormatter.ChangeFormat(input);
        Assert.That(result, Is.EqualTo(""));
    }
        [Test]
    public void TestInvalidMonth()
    {
        string input = "02/13/1994";
        var result = DateFormatter.ChangeFormat(input);
        Assert.That(result, Is.EqualTo(""));
    }

        [Test]
    public void TestTooLong()
    {
        string input = "02/02/19994";
        var result = DateFormatter.ChangeFormat(input);
        Assert.That(result, Is.EqualTo(""));
    }

        [Test]
    public void TestTooShort()
    {
        string input = "02/02/194";
        var result = DateFormatter.ChangeFormat(input);
        Assert.That(result, Is.EqualTo(""));
    }
}