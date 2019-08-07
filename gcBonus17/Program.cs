using System;

namespace gcBonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus admin Console!");            
            Run();
        }

        public static void Run()
        {
            Car c = new Car();
            CarApp carApp = new CarApp();

            carApp.GetInfo();

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Current Inventory:");
            Console.WriteLine();

            carApp.PrintList();

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();

            bool isAgain = false;

            do
            {
                carApp.GetPurchase();
                carApp.PrintList();

                Console.Write("Would you like to purchase another car? (y/n): ");
                string purchaseAgain = Console.ReadLine().ToLower().Trim();

                if (purchaseAgain == "y")
                {
                    isAgain = true;
                }

                else
                {
                    isAgain = false;
                }
            }
            while (isAgain == true);
        }
    }
}
