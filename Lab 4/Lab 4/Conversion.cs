using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
     class Conversion
     {
        double number;

        public Conversion()
        {
            number = 0;
        }

        public void getUserInput()
        {
            number = Int32.Parse(Console.ReadLine());
            
        }

        public void ConvertMilesToKm()
        {
            getUserInput();
            Console.WriteLine(number+ " Miles converts to " + (1.6d * number) + " Kilometers.");
            
        }

        public void ConvertInchesToCm()
        {
            getUserInput();
            Console.WriteLine(number + " Inches converts to " + (2.54d * number) + " Centimeters.");
            
        }

        public void ConvertLbsToKg()
        {
            getUserInput();
            Console.WriteLine(number + " Pounds converts to " + (0.45359237d * number) + " Kilograms.");
            
        }

        public void ConvertKmToMiles()
        {
            getUserInput();
            Console.WriteLine(number + " Kilometers converts to " + (0.62137119d * number) + " Miles.");
            
        }

        public void ConvertCmToInches()
        {
            getUserInput();
            Console.WriteLine(number + " Centimeters converts to " + (0.39d * number) + " Inches.");
            
        }

        public void ConvertKgToLbs()
        {
            getUserInput();
            Console.WriteLine(number + " Kilos converts to " + (2.2d * number) + " Lbs.");
            
        }


     }
    
        
}

