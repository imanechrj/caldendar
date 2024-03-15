using System;
namespace Agenda
{
    public class AlertBirthday : Alert
    {
        public int Day { get; set; }
        public Month Month { get; set; }

        public AlertBirthday(string message) : base(message)
        {
            Day = 16;
            Month = Month.Aout;
        }

        public override void DisplayMessage(Object? sender, CalendarArgs calendarArgs)
        {
            if(calendarArgs.DayNumber == Day && calendarArgs.Month == Month)
            {
                base.DisplayMessage(sender, calendarArgs);
            }
        }
    }
}

