using CarSImulator.Domain;
using System;
using static System.Console;

namespace CarSImulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] carList = new Car[10];
            uint carListNextIndexPosition = 0;
            bool shouldNotExit = true;
            while (shouldNotExit)

            {

                Console.WriteLine("1. Add car");
                Console.WriteLine("2. List car");
                Console.WriteLine("3. Simulate speed");
                Console.WriteLine("4. Exit");
                ConsoleKeyInfo keypressed = ReadKey(true);
                Clear();

                switch (keypressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Brand: ");
                        string brand = ReadLine();

                        Write("Model: ");
                        string model = ReadLine();

                        Car newCar = new Car();

                        newCar.model = model;
                        newCar.brand = brand;
                        carList[carListNextIndexPosition++] = newCar;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;

                    case ConsoleKey.D3:
                   
                        
                        break;

                    case ConsoleKey.D4:
                    
                        shouldNotExit = false;
                        break;



                }


                Clear();

            }
        }

    }
}
