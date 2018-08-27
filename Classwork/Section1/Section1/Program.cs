using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main( string[] args )
        {
            // DisplayMenu();
            PlayWithStrings();
        }

        private static void PlayWithStrings()
        {
            string hoursString = "10";

            //// From String
            ////int hours = Int32.Parse(hoursString);
            ////int hours;
            ////bool result = Int32.TryParse(hoursString, out hours);
            //bool result = Int32.TryParse(hoursString, out int hours);

            // To string
            //hoursString = hours.ToString();
            //4.75.ToString();
            //457.ToString();
            //Console.ReadLine().ToString(); // ToString converts anything to a string or =

            // Verbatim strings
            string message = "Hello\tworld"; // \t tab \n newline \"double quote (\ is a esc seq)
            string filePath = @"C:\\Temp\\Test"; // must \\ if \T is there OR @ and no longer need to \\

            //concat
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + "" + lastName;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("A)dd Movie" );
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movie");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case 'A': AddMovie(); break;
                case 'E': EditMovie(); break;
                case 'D': DeleteMovie(); break;
                case 'V': ViewMovies(); break;
                case 'Q': ; break;

                default: Console.WriteLine("Please enter a valid value."); break;
            };
        }

        private static void ViewMovies()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovie()
        {
            throw new NotImplementedException();
        }

        private static void EditMovie()
        {
            throw new NotImplementedException();
        }

        private static void AddMovie()
        {
            throw new NotImplementedException();
        }
    }
}
