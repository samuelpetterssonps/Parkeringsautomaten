namespace Test;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public void TestMethod1()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(12, "måndag");
        var expected = 0;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(20, "tisdag");
        var expected = 5;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(35, "onsdag");
        var expected = 10;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod4()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(35, "lördag");
        var expected = 5;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestMethod5()
    {
        var result = Parkeringsautomaten.Program.CalculateCost(1000, "söndag");
        var expected = 150;
        Assert.AreEqual(expected, result);
    }
}