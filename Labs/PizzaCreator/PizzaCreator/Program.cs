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
            while (true)
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
            SizeSelection();
            MeatSelection();
            VeggieSelection();
            SauceSelection();
            DeliveryOptions();

        }

        private static void SizeSelection()
        {
            Console.WriteLine("Size (one required).");
            Console.WriteLine("\t1. Small ($5)");
            Console.WriteLine("\t2. Medium ($6.25)");
            Console.WriteLine("\t3. Large (8.25)");

            size = ReadInt32(1, 3);

        }

        private static int ReadInt32( int minValue, int maxValue )
        {
            while (true)
            {

                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var result))
                {
                    if (result >= minValue && result <= maxValue)
                        return result;
                };

                Console.WriteLine($"You must enter an interger value >= {minValue}");
            };
        }

        private static void MeatSelection()
        {
            while (true)
            {
                Console.WriteLine("Meats (zero or more). Each option is $0.75 extra.");
                Console.WriteLine("\t1. Bacon");
                Console.WriteLine("\t2. Ham");
                Console.WriteLine("\t3. Pepperoni");
                Console.WriteLine("\t4. Sausage");
                Console.WriteLine("\t5. Done");


                var temp = ReadInt32(1, 5);
                switch (temp)
                {
                    case 1:
                    bacon = !bacon;
                    break;

                    case 2:
                    ham = !ham;
                    break;

                    case 3:
                    pepperoni = !pepperoni;
                    break;

                    case 4:
                    sausage = !sausage;
                    break;

                    case 5: return;

                }

            }
        }
        private static void VeggieSelection()
        {
            while (true)
            {
                Console.WriteLine("Vegetables (zero or more). Each option is $0.50 extra.");
                Console.WriteLine("\t1. Black olives");
                Console.WriteLine("\t2. Mushrooms");
                Console.WriteLine("\t3. Onions");
                Console.WriteLine("\t4. Peppers");
                Console.WriteLine("\t5. Done");


                var temp = ReadInt32(1, 5);
                switch (temp)
                {
                    case 1:
                    blackOlives = !blackOlives;
                    break;

                    case 2:
                    mushrooms = !mushrooms;
                    break;

                    case 3:
                    onions = !onions;
                    break;

                    case 4:
                    peppers = !peppers;
                    break;

                    case 5:
                    return;

                }

            }
        }

        private static void SauceSelection()
        {
            Console.WriteLine("Sauce (one is required).");
            Console.WriteLine("\t1. Traditional ($0)");
            Console.WriteLine("\t2. Garlic ($1)");
            Console.WriteLine("\t3. Oregano ($1)");

            sauce = ReadInt32(1, 3);

        }

        private static void DeliveryOptions()
        {
            Console.WriteLine("Delivery (one is required).");
            Console.WriteLine("\t1. Take Out ($0)");
            Console.WriteLine("\t2. Delivery ($2.50)");

            delivery = ReadInt32(1, 2);
        }

        private static void ModifyOrder()
        {

            Console.WriteLine("Modify Order");
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Here is your order");

            //CalculateTotal();

        }

        private static decimal CalculateTotal)
        {
            var price = 0m;
            switch(size)
            { 
                case 1: price +=5; break;
                
                case 2: price +=6.25; break;
                 
                case 3: price +=8.25; break;
            };
            
            
            
            
            var small = 5.00;
            var medium = 6.25;
            var large = 8.25;
            var xMeats = 0.75;
            var vegetables = 0.50;
            var sauce = 1.00;
            var xCheese = 1.25;

            var delivery = 2.50;

            return price;

        }

        static int size;
        static bool bacon;
        static bool ham;
        static bool pepperoni;
        static bool sausage;
        static bool blackOlives;
        static bool mushrooms;
        static bool onions;
        static bool peppers;
        static int sauce;
        static int delivery;
                
        
    }
}
