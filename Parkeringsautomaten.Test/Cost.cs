namespace Parkeringsautomaten.Test;

[TestClass]
public sealed class Cost
{
    [TestMethod]
    public void NoDuration()
    {
        var result = Lib.Cost.Calculate(0, DayOfWeek.Monday);
        var expected = 0;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShortDuration()
    {
        var result = Lib.Cost.Calculate(12, DayOfWeek.Monday);
        var expected = 0;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Normal1()
    {
        var result = Lib.Cost.Calculate(20, DayOfWeek.Tuesday);
        var expected = 5;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Normal2()
    {
        var result = Lib.Cost.Calculate(35, DayOfWeek.Wednesday);
        var expected = 10;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Weekend()
    {
        var result = Lib.Cost.Calculate(35, DayOfWeek.Saturday);
        var expected = 5;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LongDuration()
    {
        var result = Lib.Cost.Calculate(1000, DayOfWeek.Sunday);
        var expected = 150;
        Assert.AreEqual(expected, result);
    }
}