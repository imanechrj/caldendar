using System;
namespace Agenda
{
	public class CalendarArgs : EventArgs
	{
        public int Year { get; set; }
        public Month Month { get; set; }
        public Day DayofTheWeek { get; set; }
        public int DayNumber { get; set; }

        public CalendarArgs(int year, Month month, Day dayofTheWeek, int dayNumber)
        {
            Year = year;
            Month = month;
            DayofTheWeek = dayofTheWeek;
            DayNumber = dayNumber;
        }
    }
}

