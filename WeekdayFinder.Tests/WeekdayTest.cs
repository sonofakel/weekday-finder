using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WeekdayFinder.Models;
using System;

namespace WeekdayFinder.Tests 
{
    [TestClass]
    public class WeekdayTest
    {
        [TestMethod] 
        public void GetWeekday_UserEnters20010911_Tuesday()
        {
            Weekday testWeekday = new Weekday(2001,09,11);
            string expected = "Tuesday";
            string actual = testWeekday.GetWeekday();
            Assert.AreEqual(expected, actual);
        }
    }
}