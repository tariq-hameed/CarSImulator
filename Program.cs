using CarSImulator.Domain;
using System;
using static System.Console;
using System.Threading;

namespace CarSImulator
{   
    

    class Program
    {
        static Car[] carList = new Car[10];
        static void Main(string[] args)
        {
            bool shouldNotExit = true;

            uint carListCurrentIndexPosition = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. Change Registration Number");
                WriteLine("4. Simulate speed");
                WriteLine("5. Exit");

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

                                string brand = car.Brand.PadRight(10, ' ');
                                string model = car.Model.PadRight(10, ' ');
                                string registrationNumber = car.RegistrationNumber.PadRight(10, ' ');

                                Write(brand);
                                Write(model);
                                WriteLine(registrationNumber);
                            }

                            ReadKey(true);
                        }

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {

                            Write("Previous registration number: ");
                            string previousRegistrationNumber = ReadLine();


                            Write("New registration number: ");
                            string newRegistrationNumber = ReadLine();

                            Car theCar = SearchCarByRegistrationNumber(previousRegistrationNumber); 

                            if(theCar != null)
                            {

                                theCar.RegistrationNumber= newRegistrationNumber;
                            }
                            else
                            {

                                WriteLine("Car not found");
                                Thread.Sleep(2000);
                                
                            }


                        }

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }

        private static Car SearchCarByRegistrationNumber(string previousRegistrationNumber)
        {
            Car carReferenceToReturn = null;

            foreach (Car carReference in carList)
            {
                if (carReference == null) continue;

                if (carReference.RegistrationNumber == previousRegistrationNumber)
                {
                    carReferenceToReturn = carReference;
                    break;
                }
            }

            return carReferenceToReturn;
        }
    }
}
