using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExercise
{
    class Program
    {
        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week. \n Use correct format then press Enter:");
            string userInput = Console.ReadLine();
            daysOfTheWeek days = (daysOfTheWeek)Enum.ToObject(typeof(daysOfTheWeek), 7);

            try
            {
                days = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), userInput);
                {
                    Console.WriteLine("You entered: " + days);
                }
               
            }
            catch (Exception)
                {
                Console.WriteLine("Please enter an actual day of the week. (Capitalize correctly)");
                }
            

            Console.ReadLine();

        }
        

    }
}



