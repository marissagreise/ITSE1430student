using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            } while (notQuit);
        }

        private static bool DisplayMenu()
        {
            while(true)
            {

                Console.WriteLine("N)ew Order ");
                Console.WriteLine("M)odify Order ");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit ");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'n':
                    case 'N': NewOrder(); return true;

                    case 'm':
                    case 'M': ModifyOrder(); return true;

                    case 'd':
                    case 'D': DisplayOrder(); return true;

                    case 'q':
                    case 'Q': return false;

                    default: Console.WriteLine("Please enter a valid value."); break;

                }
            };
        }

        private static bool NewOrder()
        {
            double small = 5.00;
            double medium = 6.25;
            double large = 8.25;

            Console.WriteLine("Size (one required).");
            Console.WriteLine("\t1. Small ($5)");
            Console.WriteLine("\t2. Medium ($6.25)");
            Console.WriteLine("\t3. Large (8.25)");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case'1':
                SmallPizza(); return true;

                case '2':
                MediumPizza(); return true;

                case '3':
                LargePizza(); return true;

            }

            
        }
        private static bool SmallPizza()
        {
            Console.WriteLine("Meats (zero or more). Each option is $0.75 extra.");
            Console.WriteLine("\t1. Bacon");
            Console.WriteLine("\t2. Ham");
            Console.WriteLine("\t3. Pepperoni");
            Console.WriteLine("\t4. Sausage");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case '1':
                
            
            }

        }

        private static bool MediumPizza()
        {

        }

        private static bool LargePizza()
        {

        }

        private static void ModifyOrder()
        {
            Console.WriteLine("Modify Order");
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Display Order");
        }
        

        double meats = 0.75;
        double vegetables = 0.50;
        double sauce = 1.00;
        double xCheese = 1.25;

        double delivery = 2.50;
    }
}
