using System;
using System.Security.Cryptography;

namespace Agenda
{
    public class AlertBirthdayMonth : Alert
    {
        public Month Month { get; set; }

        public AlertBirthdayMonth(string message) : base(message)
        {
            Month = Month.Juillet;
        }

        public override void DisplayMessage(Object? sender, CalendarArgs calendarArgs)
        {
            if (calendarArgs.Month == Month)
            {
                base.DisplayMessage(sender, calendarArgs);
            }
        }
    }
}

