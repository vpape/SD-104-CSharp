using System;
using System.Collections.Generic;
using System.Text;

namespace ExamReview
{
    class ShipTruck
    {
        List<Vehicle> Ride;

        public ShipTruck()
        {
            Ride = new List<Vehicle>();
        }

        public List<Vehicle> GetVehicles()
        {
            return Ride;
            
        }
            
        
        public void AddVehciles(Vehicle MyVehicle)
        {
            Ride.Add(MyVehicle);
            
        }

        

    }
}
