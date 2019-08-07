using System;
using System.Collections.Generic;
using System.Text;

namespace gcBonus17
{
    class CarApp
    {
        List<Car> cars = new List<Car>();
        
        public CarApp() { }

        public void GetInfo()
        {
            cars.Add(new Car("Tesla", "Model S", 2019, 50000));
            cars.Add(new UsedCar("Dodge", "Charger", 1969, 30000, 4500));
            cars.Add(new Car("Nissan", "GTR", 2017, 89000));
            cars.Add(new Car("Ford", "GT", 2019, 65000));
            cars.Add(new Car("Toyota", "Supra", 2020, 100525));
            cars.Add(new UsedCar("Ford", "Escape", 2015, 20000, 65252));
            cars.Add(new UsedCar("Honda", "Civic", 2018, 25000, 2000));            
        }

        public void PrintList()
        {
            for (int j = 0; j < cars.Count; j++)
            {
                Console.WriteLine(cars[j].ToString());
            }
        }

        public void GetPurchase()
        {
                Console.Write("Which car would you like to purchase?: ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine(cars[choice - 1]);
                Console.WriteLine();
                Console.Write("Are you sure you would like to purchase this car? (y/n): ");
                string input = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();
                Console.WriteLine("...");
                Console.WriteLine();

                if (input == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("Congradulations on the purchase of your new car!");
                    Console.WriteLine();
                    Console.WriteLine("...");
                    Console.WriteLine();
                    Console.WriteLine("In case you know someone who is in the market for a new car, Here is our inventory!");
                    Console.WriteLine();
                    Console.WriteLine("Minus the car you just purchased of course!");
                    Console.WriteLine();
                    Console.WriteLine("...");
                    Console.WriteLine();
                    cars.Remove(cars[choice - 1]);
                }
                
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("...");
                    Console.WriteLine();
                    GetPurchase();
                }
        }
    }
}