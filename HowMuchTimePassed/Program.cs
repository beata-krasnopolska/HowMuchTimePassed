using System;

namespace HowMuchTimePassed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program retrieves the current date and displays how much time passed since indicated date");

            DateTime currentDate = DateTime.Today;
            DateTime birthday = new DateTime(2019, 5, 17);

            var timeSpan = currentDate - birthday;
            var monthsSpan = MonthDifferencer.MonthDifference(currentDate, birthday);

            Console.WriteLine("Number of days since {0} to {1} : {2}", birthday.ToString("d"), currentDate.ToString("d"), timeSpan.Days);
            Console.WriteLine("Total number of months since {0} to {1} : {2}", birthday.ToString("d"), currentDate.ToString("d"),monthsSpan);

            Console.ReadKey();
        }        
    }
}
