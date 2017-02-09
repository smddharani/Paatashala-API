using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI
{
    public class TimeTableStructure
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<WeekdayTimeTable> WeekdayTimeTables { get; set; }

        public TimeTableStructure()
        {
            WeekdayTimeTables = new List<WeekdayTimeTable>();
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Sunday",
                WeekdayName = Weekday.SUNDAY
            });
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Monday",
                WeekdayName = Weekday.MONDAY
            });
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Tuesday",
                WeekdayName = Weekday.TUESDAY
            });
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Wednesday",
                WeekdayName = Weekday.WEDNESDAY
            });
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Thursday",
                WeekdayName = Weekday.THURSDAY
            });
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Friday",
                WeekdayName = Weekday.FRIDAY
            });
            WeekdayTimeTables.Add(new WeekdayTimeTable()
            {
                Name = "Satarday",
                WeekdayName = Weekday.SATARDAY
            });
        }
    }
    public class WeekdayTimeTable
    {
        public Weekday WeekdayName { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public List<Period> Periods { get; set; }

        public WeekdayTimeTable()
        {
            Visible = false;
            Periods = new List<Period>();
        }
    }
    public enum Weekday
    {
        SUNDAY = 0,
        MONDAY = 1,
        TUESDAY = 2,
        WEDNESDAY = 3,
        THURSDAY = 4,
        FRIDAY = 5,
        SATARDAY = 6
    }
    public class Period
    {
        public long Id { get; set; }
        public TimeTableSubject Subject { get; set; }
        public string FacultyName { get; set; }
        public long FacultyId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
    public class TimeTableSubject
    {
        public string Name { get; set; }
        public long Id { get; set; }
    }
}