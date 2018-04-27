using System;
using System.Collections.Generic;

namespace ExamReview
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ShipTruck MyVehicle = new ShipTruck();


            Vehicle Chevorlet = new Vehicle("Chevorlet", "1500 LTZ");
            Vehicle Honda = new Vehicle("Honda", "Accord");
            Vehicle Ford = new Vehicle("Ford", "F150");

            
            MyVehicle.AddVehciles(Chevorlet);
            MyVehicle.AddVehciles(Honda);
            MyVehicle.AddVehciles(Ford);




            List<Vehicle> VehicleList = MyVehicle.GetVehicles();
            {
                for (int i = 0; i < VehicleList.Count; i++)
                {

                    VehicleList[i].DisPlayName();
                    VehicleList[i].Start();

                
                }
            }

            



        }
        
    }
}
