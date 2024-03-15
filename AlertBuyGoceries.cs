using System;
using System.Security.Cryptography;

namespace Agenda
{
    public class AlertBuyGroceries : Alert
    {
        public int Groceries1 { get; set; }
        public int Groceries2 { get; set; }


        public AlertBuyGroceries(string message) : base(message)
        {
            Groceries1 = 5;
            Groceries2 = 17;
        }

        public override void DisplayMessage(Object? sender, CalendarArgs calendarArgs)
        {
            if (calendarArgs.DayNumber == Groceries1 || calendarArgs.DayNumber == Groceries2)
            {
                base.DisplayMessage(sender, calendarArgs);
            }
        }

    }
}

