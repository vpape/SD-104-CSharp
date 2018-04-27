using System;
using System.Collections.Generic;
using System.Text;

namespace ExamReview
{
    class Vehicle
    {
        string Make;
        string Model;

       
        public  Vehicle()
        {
            Make = "Honda";
            Model = "Civic";
        }

        public Vehicle(string Make, string Model)
        {
            this.Make = Make;
            this.Model = Model;
        }
       

        public void Start()
        {
            
            Console.WriteLine("Vvvrrroooommmm!!");
            Console.ReadLine();
            
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
            Console.ReadLine();
        }

        public void DisPlayName()
        {
            Console.WriteLine("Model: " + Model +  " Make: " + Make);
            Console.ReadLine();
        }

     
    }
}
