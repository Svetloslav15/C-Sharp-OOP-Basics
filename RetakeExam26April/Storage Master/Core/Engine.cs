using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class Engine
    {
        private StorageMaster storageMaster;
        public Engine(StorageMaster storageMaster)
        {
            this.storageMaster = storageMaster;
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                try
                {
                    switch (command)
                    {
                        case "AddProduct":
                            {
                                string type = tokens[1];
                                double price = double.Parse(tokens[2]);
                                Print(this.storageMaster.AddProduct(type, price));
                            }; break;
                        case "RegisterStorage":
                            {
                                string type = tokens[1];
                                string name = tokens[2];
                                Print(this.storageMaster.RegisterStorage(type, name));
                            }; break;
                        case "SelectVehicle":
                            {
                                string storageName = tokens[1];
                                int garageSlot = int.Parse(tokens[2]);
                                Print(this.storageMaster.SelectVehicle(storageName, garageSlot));
                            }; break;
                        case "SendVehicleTo":
                            {
                                string sourceName = tokens[1];
                                int garageSlot = int.Parse(tokens[2]);
                                string destinationName = tokens[3];
                                Print(this.storageMaster.SendVehicleTo(sourceName, garageSlot, destinationName));
                            }; break;
                        case "UnloadVehicle":
                            {
                                string storageName = tokens[1];
                                int garageSlot = int.Parse(tokens[2]);
                                Print(this.storageMaster.UnloadVehicle(storageName, garageSlot));
                            }; break;
                        case "GetStorageStatus":
                            {
                                string storageName = tokens[1];
                                Print(this.storageMaster.GetStorageStatus(storageName));
                            }; break;
                        case "LoadVehicle":
                            {
                                var products = tokens.Skip(1).ToList();
                                Print(this.storageMaster.LoadVehicle(products));
                            }
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                
                input = Console.ReadLine();
            }
            Print(storageMaster.GetSummary());
        }
        private void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
