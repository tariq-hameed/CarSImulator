using CarSImulator.Domain;
using System;
using static System.Console;

namespace CarSImulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldNotExit = true;

            Car[] carList = new Car[10];
            uint carListCurrentIndexPosition = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. Simulate speed");
                WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Write("Brand: ");

                            string brand = ReadLine();

                            Write("Model: ");

                            string model = ReadLine();

                            Write("Registration number: ");

                            string registrationNumber = ReadLine();

                            Car newCar = new Car(brand, model, registrationNumber);

                            carList[carListCurrentIndexPosition++] = newCar;
                        }

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            string brandHeader = "Brand".PadRight(10, ' ');
                            string modelHeader = "Model".PadRight(10, ' ');
                            string registrationNumberHeader = "Registration number";

                            Write(brandHeader);
                            Write(modelHeader);
                            WriteLine(registrationNumberHeader);

                            WriteLine("---------------------------------------------------");

                            foreach (Car car in carList)
                            {
                                if (car == null) continue;

                                string brand = car.GetBrand().PadRight(10, ' ');
                                string model = car.GetModel.PadRight(10, ' ');
                                string registrationNumber = car.GetRegistrationNumber().PadRight(10, ' ');

                                Write(brand);
                                Write(model);
                                WriteLine(registrationNumber);
                            }

                            ReadKey(true);
                        }

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }
    }
}
