using System;
namespace Agenda
{
    public class AlertNationalDay : Alert
    {
        public int DayNumber { get; set; }
        public Month Month { get; set; }

        public AlertNationalDay(string message) : base(message)
        {
            DayNumber = 14;
            Month = Month.Juillet;
        }

        public override void DisplayMessage(Object? sender, CalendarArgs calendarArgs)
        {
            if (calendarArgs.DayNumber == DayNumber && calendarArgs.Month == Month)
            {
                base.DisplayMessage(sender, calendarArgs);
            }
        }
    }
}

