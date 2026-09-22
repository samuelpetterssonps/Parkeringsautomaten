namespace Parkeringsautomaten.Test;

[TestClass]
public class DayOfWeekParser
{
    [TestMethod]
    public void SwedishMonday()
    {
        var result = Lib.DayOfWeekParser.FromString("måndag");
        var expected = DayOfWeek.Monday;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SwedishTuesday()
    {
        var result = Lib.DayOfWeekParser.FromString("Tisdag");
        var expected = DayOfWeek.Tuesday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void SwedishWednesday()
    {
        var result = Lib.DayOfWeekParser.FromString("ONSDAG");
        var expected = DayOfWeek.Wednesday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void SwedishThursday()
    {
        var result = Lib.DayOfWeekParser.FromString("torsDag");
        var expected = DayOfWeek.Thursday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void SwedishFriday()
    {
        var result = Lib.DayOfWeekParser.FromString("fredag");
        var expected = DayOfWeek.Friday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void SwedishSaturday()
    {
        var result = Lib.DayOfWeekParser.FromString("lördag");
        var expected = DayOfWeek.Saturday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void SwedishSunday()
    {
        var result = Lib.DayOfWeekParser.FromString("söndag");
        var expected = DayOfWeek.Sunday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void EnglishMonday()
    {
        var result = Lib.DayOfWeekParser.FromString("monday");
        var expected = DayOfWeek.Monday;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void EnglishTuesday()
    {
        var result = Lib.DayOfWeekParser.FromString("tuesday");
        var expected = DayOfWeek.Tuesday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void EnglishWednesday()
    {
        var result = Lib.DayOfWeekParser.FromString("wednesday");
        var expected = DayOfWeek.Wednesday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void EnglishThursday()
    {
        var result = Lib.DayOfWeekParser.FromString("thursday");
        var expected = DayOfWeek.Thursday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void EnglishFriday()
    {
        var result = Lib.DayOfWeekParser.FromString("friday");
        var expected = DayOfWeek.Friday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void EnglishSaturday()
    {
        var result = Lib.DayOfWeekParser.FromString("saturday");
        var expected = DayOfWeek.Saturday;
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void EnglishSunday()
    {
        var result = Lib.DayOfWeekParser.FromString("sunday");
        var expected = DayOfWeek.Sunday;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void EmptyString()
    {
        var result = Lib.DayOfWeekParser.FromString("");
        var expected = DayOfWeek.Monday;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void InvalidString()
    {
        var result = Lib.DayOfWeekParser.FromString("blablabla");
        var expected = DayOfWeek.Monday;
        Assert.AreEqual(expected, result);
    }
}