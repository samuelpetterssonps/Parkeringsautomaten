using Parkeringsautomaten;

namespace Test;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public void TestMethod1()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(12, Program.Day.Monday);
        var expected = 0;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(20, Program.Day.Tuesday);
        var expected = 5;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(35, Program.Day.Wednesday);
        var expected = 10;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod4()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(35, Program.Day.Saturday);
        var expected = 5;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod5()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(1000, Program.Day.Sunday);
        var expected = 150;
        Assert.AreEqual(expected, result);
    }
}