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
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();    //declare outside the scope
            } while (notQuit);
           
           // PlayWithStrings();
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
            string message = "Hello\tworld"; // \t tab \n newline \"double quote" (\ is a esc seq)
            string filePath = @"C:\\Temp\\Test"; // must \\ if \T is there OR @ and no longer need to \\ (esc)

            //concat
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + "" + lastName;

            // strings are immutable - this produces a new string
            // name = "Hello " + name;
            Console.WriteLine("Hello " + name); // Approach 1 
            Console.WriteLine("Hello {0} {1}", firstName, lastName); // A#2 used for tables and its called string formatting
            string str = String.Format("Hello {0} {1}", firstName, lastName); // A#3 exact same func. as above. 
            Console.WriteLine(str);

            // Approach#4 designed to let compiler to auto gen. this code for us
            Console.WriteLine($"Hello {firstName} {lastName}"); // $ interperated string {variables, and identifiers inside here}

            //Null vs empty
            string missing = null; //null is = to 0
            string empty = "";     // string with no content (not the same as null)
            string empty2 = String.Empty; //dont do this, only when a language doesnt support strings.
            
            // Checking for empty strings
            //if (firstName.Length ==0)
            //if (missing != null && firstName != "")   
            if (!String.IsNullOrEmpty(firstName))       // use this more readable and less typing
                Console.WriteLine(firstName);

            // other stuff
            string upper = firstName.ToUpper();     // this will cap all of the string
            string lowerName = firstName.ToUpper(); // undercase all of string

            //Comparison
            bool areEqual = firstName == lastName;
            areEqual = firstName.ToLower() == lastName.ToLower(); //waste of time
            areEqual = String.Compare(firstName, lastName, true) == 0; //works the best for all languages

            // looking for specific values for string
            bool startsWithA = firstName.StartsWith("A");
            bool endsWithA = firstName.EndsWith("A");
            bool hasA = firstName.IndexOf("A") >= 0; //looks for "A" and how many
            string subset = firstName.Substring(4); //split a string down the middle not the most friendly

            // Clean up
            string cleanMe = firstName.Trim(); // TrimStart, TrimEnd
            string makeLonger = firstName.PadLeft(20); // Padright.. builds table columns even width. 


        }

        private static bool DisplayMenu()
        {
            while (true)
            { 
            Console.WriteLine("A)dd Movie" );
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movie");
            Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A': AddMovie(); return true;       //every case statement must end with a (return or break)

                    case 'e':
                    case 'E': EditMovie(); return true;

                    case 'd':
                    case 'D': DeleteMovie(); return true;

                    case 'v':
                    case 'V': ViewMovies(); return true;

                    case 'q':
                    case 'Q': ; return false;

                    default: Console.WriteLine("Please enter a valid value."); break;
                }
            };
        }

        private static void ViewMovies()
        {
            Console.WriteLine("ViewMovie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
        }

        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
        }

        private static void AddMovie()
        {
            Console.WriteLine("AddMovie");
        }
    }
}
