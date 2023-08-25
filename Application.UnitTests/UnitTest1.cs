namespace Application.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test3()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test()
    {
        var a = "hello";
        Assert.Fail();
    }
    
    [Test]
    public void Test5()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test53()
    {
        var aaa = 4545;
        Assert.Pass();
    }
    
    [Test]
    public void Test7()
    {
        Assert.Pass();
    }
}