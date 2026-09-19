using Parkeringsautomaten;

namespace Test;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public void TestMethod1()
    {
        var result = Program.CalculateCost(12, DayOfWeek.Monday);
        var expected = 0;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var result = Program.CalculateCost(20, DayOfWeek.Tuesday);
        var expected = 5;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        var result = Program.CalculateCost(35, DayOfWeek.Wednesday);
        var expected = 10;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod4()
    {
        var result = Program.CalculateCost(35, DayOfWeek.Saturday);
        var expected = 5;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod5()
    {
        var result = Program.CalculateCost(1000, DayOfWeek.Sunday);
        var expected = 150;
        Assert.AreEqual(expected, result);
    }
}