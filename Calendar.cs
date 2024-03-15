using System;
namespace Agenda
{
	public class Calendar
	{
		public int Year { get; set; }
		public Month Month { get; set; }
		public Day DayofTheWeek { get; set; }
		public int DayNumber { get; set; }
		public event EventHandler<CalendarArgs> OnDAy;
        public event EventHandler<CalendarArgs> OnWeek;
        public event EventHandler<CalendarArgs> OnMonth;
        public event EventHandler<CalendarArgs> OnYear;


        public Calendar(int year)
        {
			Year = year;
			DayofTheWeek = Day.Lundi;
			Month = Month.Janvier;
        }

        public void NextDay()
		{
			Console.WriteLine("Combien de jours ? ");
			int numberOfDays = int.Parse(Console.ReadLine());
				DayNumber = 1;
			for (int i = 0; i < numberOfDays; i++)
			{
				Console.WriteLine("\n" + DayNumber + " " + DayofTheWeek + " " + Month + " " + Year );
                CalendarArgs calendarArgs = new CalendarArgs(Year, Month, DayofTheWeek, DayNumber);

				if (OnDAy != null)
				{
                    OnDAy(this, calendarArgs);
                }
                DayNumber ++;
                DayofTheWeek++;
				

				if (i == 359)
				{
                    if (OnYear != null)
                    {
                        OnYear(this, calendarArgs);
                    }
					Year++;
				}

				if(DayNumber == 31)
				{
                    if (OnMonth != null)
                    { 
                        OnMonth(this, calendarArgs);
                    }
					if(Month == Month.NextYear)
					{
						Month = Month.Janvier;
					}
                Month++;
				}

				if(DayNumber == 31)
				{
					DayNumber = 1;
				}

				if(DayofTheWeek == Day.NextWeek)
				{
                    if (OnWeek != null)
                    {
                        OnWeek(this, calendarArgs);
                    }
					DayofTheWeek = Day.Lundi;
				}
			}
		}
	}
}

