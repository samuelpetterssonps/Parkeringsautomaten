namespace Parkeringsautomaten.Lib;

public static class DayOfWeekParser
{
    public static DayOfWeek FromString(string str)
    {
        return str.ToLower() switch
        {
            "monday" or "måndag" => DayOfWeek.Monday,
            "tisdag" or "tuesday" => DayOfWeek.Tuesday,
            "onsdag" or "wednesday" => DayOfWeek.Wednesday,
            "torsdag" or "thursday" => DayOfWeek.Thursday,
            "fredag" or "friday" => DayOfWeek.Friday,
            "lördag" or "saturday" => DayOfWeek.Saturday,
            "sunday" or "söndag" => DayOfWeek.Sunday,
            _ => DayOfWeek.Monday,
        };
    }
}