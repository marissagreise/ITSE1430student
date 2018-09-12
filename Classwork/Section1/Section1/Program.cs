/*
 * ITSE 1430 
 * Sample Implementation
 */
using System;

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
        private static void PlayWithObjects()
        {
            int hours = 10;
            Int32 hoursFull = 10;
            var areEqual = hours == hoursFull;


            var obj1 = "Hello";
            DisplayObject(obj1);

        }
        private static void DisplayObject( object value )
        {
            if (value == null)
                return;

            // Approach 1
            if (value is string)    // type check, what is the type of value? object, Make sense?
            {
                var str = (string)value;
                Console.WriteLine(str);
            } else
            {
                var str = value.ToString();
                Console.WriteLine(str);
            };

            //Approach 2
            var str2 = value as string;
            if (str2 != null)
                Console.WriteLine(str2);
            else
                Console.WriteLine(value.ToString());

            //Approach 3
            var str3 = value as string;
            Console.WriteLine((str3 != null) ? str3.ToString() : value.ToString());

            //Approach 4
            var str4 = value as string;
            Console.WriteLine((str4 ?? value).ToString()); // null coalescing

            //Approach 5** efficent and protects from errors
            //var str5 = value is string;
            if (value is string str5)
                Console.WriteLine(str5.ToString());
            else
                Console.WriteLine(value.ToString());     // coalescing 2

            //Approach 6** efficent and protects from errors
            var str6 = value as string;
            Console.WriteLine((str6?.ToString()); // null conditional  E, ?.(func)


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

        private static void PlayWithArrays()
        {
            int count = ReadInt32("How many names?", 1);

            string[] names = new string[count];
            for (int index = 0; index < count; ++index)
            {
                Console.WriteLine("Name? ");
                names[index] = Console.ReadLine();
            };

            foreach (string name in names)
            //for (int index = 0; index < names.Length; ++index)
            {
                // readonly - not allowed
                //name = "";
                string str = name;
                str = "";
                //Console.WriteLine(names[index]);
                Console.WriteLine(name);
            };
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("V)iew Movie");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A':
                    AddMovie();
                    return true;       //every case statement must end with a (return or break)

                    case 'e':
                    case 'E':
                    EditMovie();
                    return true;

                    case 'd':
                    case 'D':
                    DeleteMovie();
                    return true;

                    case 'v':
                    case 'V':
                    ViewMovies();
                    return true;

                    case 'q':
                    case 'Q':
                    ;
                    return false;

                    default:
                    Console.WriteLine("Please enter a valid value.");
                    break;
                }
            };
        }

        private static void ViewMovies()
        {
            if (!String.IsNullOrEmpty(name))
            {
                Console.WriteLine("No movies available");
                return;
            };

            Console.WriteLine(name);

            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);


            Console.WriteLine($"Run length = {runLength} min");
        }

        private static void DeleteMovie()
        {
            if (Confirm("Are you sure you want to delete this movie?"))
            {
                //"Delete" the movie
                name = null;
                description = null;
                runLength = 0;
            };
        }

        private static bool Confirm( string message )
        {
            Console.WriteLine($"{message} (Y/N)");

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                    return true;

                    case 'N':
                    case 'n':
                    return false;
                };
            } while (true);
            //if (key.KeyChar == 'Y')
            //    return true;
            //else if (key.KeyChar == 'N')
            //    return false;
        }

        private static void EditMovie()
        {
            ViewMovies();

            var newName = ReadString("Enter a name (or press ENTER for default): ", false); // or can take out the false
            if (String.IsNullOrEmpty(newName))
                name = newName;

            var newDescription = ReadString("Enter a description (or press ENTER for default): ");
            if (!String.IsNullOrEmpty(newDescription))
                description = newDescription;

            var newLength = ReadInt32("Enter run length (in minutes): ", 0);
            if (newLength > 0)
                runLength = newLength;
        }

        private static void AddMovie()
        {
            name = ReadString("Enter a name: ", true);
            description = ReadString("Enter a description: ");
            runLength = ReadInt32("Enter run length (in minutes): ", 0);

        }

        private static int ReadInt32( string message, int minValue )
        {
            while (true)
            {
                Console.WriteLine(message);

                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var result))  // var is used in local variables
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an interger value >= {minValue}");
            };
        }

        private static string ReadString( string message )
        {
            return ReadString(message, false);      // calls helper function
        }
        private static string ReadString( string message, bool required )
        {
            while (true)
            {

                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;
                Console.WriteLine("You must enter a value");
            };
        }

        // A movie
        static string name;
        static string description;
        static int runLength;
        //static DateTime releaseDate;
    }
}
