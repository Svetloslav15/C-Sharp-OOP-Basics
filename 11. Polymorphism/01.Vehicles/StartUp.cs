using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int line = 0; line < numberOfCommands; line++)
            {
                string[] info = Console.ReadLine().Split();
                string command = info[0];
                string vehicle = info[1];
                double number = double.Parse(info[2]);
                string result;
                if (command == "Drive")
                {
                    result = vehicle == "Car" ? car.Driving(number) : truck.Driving(number);
                    Console.WriteLine(result);
                }
                else if (command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(number);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(number);
                    }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
