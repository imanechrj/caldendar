using System;
namespace Agenda
{
	public class Alert
	{
		public string Message { get; set; }

        public Alert(string message)
        {
            Message = message;
        }


        public virtual void DisplayMessage(Object? sender, CalendarArgs calendarArgs)
        {
            Console.WriteLine(Message);
        }
    }
}

