using System;
using System.Collections.Generic;

namespace WeekdayFinder.Models
{
  public class Weekday
  {
    private int _year;
    private int _month;
    private int _day;

    public Weekday(int year, int month, int day)
    {
        _year = year;
        _month = month;
        _day = day;
    }
    public string GetWeekday()
    {
        DateTime newDate = new DateTime(_year, _month, _day);
        string newDayOfWeek = newDate.DayOfWeek.ToString();
        Console.WriteLine(newDayOfWeek);
        return newDayOfWeek;
    }

  }
}