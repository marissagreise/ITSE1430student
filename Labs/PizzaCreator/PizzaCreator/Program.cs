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

        private static void NewOrder()
        {
            Console.WriteLine("New Order");
        }

        private static void ModifyOrder()
        {
            Console.WriteLine("Modify Order");
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Display Order");
        }

    }
}
