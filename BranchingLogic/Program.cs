using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF x < 10 
            //PRINT x is less than 10

            //int x;
            //x = 10;
            //if (x < 10)
            //{
            //    Console.WriteLine("X is less than 10!");
            //}
            //else
            //{
            //    Console.WriteLine("X is more than 10!");
            //}
            //Console.WriteLine("This happens no matter what!");
            //Console.ReadLine();

            // If x is less than 10 and greater than 5

            //var x = 4;
            //if ((x < 10) || 
            //    (x > 5)) 
            //{
            //    Console.WriteLine("YOu're above 50% there");
            //}

            DaysOfTheWeek today = DaysOfTheWeek.Friday;

            var something = Console.ReadLine();

            int value = int.Parse(something);

            today = (value > -1 && value < 7) ?
                (DaysOfTheWeek)value :
                DaysOfTheWeek.Wednesday;

            switch (today)
            { 
                case DaysOfTheWeek.Wednesday:
                    Console.WriteLine("It's hump day, woohoo!");
                    break;
                case DaysOfTheWeek.Tuesday:
                    Console.WriteLine("We got the club going up!  On a...");
                    break;
                case DaysOfTheWeek.Thursday:
                    Console.WriteLine("I'm Thirsty");
                    break;
                case DaysOfTheWeek.Friday:
                case DaysOfTheWeek.Saturday:
                    Console.WriteLine("Date night!");
                    break;
                default:
                    Console.WriteLine("This was probz and error M8");
                    break;
            }
            Console.ReadLine();
        }
    }

    enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
