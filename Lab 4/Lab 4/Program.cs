using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice;


            //Miles to KM: 1.6 * miles -a
            //KM to Miles: 0.62137119 * km - d

            //Inches to CM: 2.54 * inches - b
            //CM to Inches: 0.39 * cm - E

            //lbs to kg: 0.45359237 * lbs - c
            //kg to lbs: 2.2 * kg - f




            Console.WriteLine("This program has multiple functionalities" );
            Console.WriteLine("A to convert miles to KM, B to convert inches to CM, C to convert lbs to kg");
            Console.WriteLine("D to convert KM to miles, E to convert CM to inches, F to convert kg to lbs");
            Console.WriteLine("Enter choice: ");
            choice = Console.ReadLine();


            switch (choice.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter the Miles to convert: ");
                    double miles = Int32.Parse(Console.ReadLine());
                    double km = miles * 1.6;
                    Console.WriteLine(miles + " miles is = " + km + " kilometers");
                    break;

                   
                case "B":
                    Console.WriteLine("Enter the inches to convert: ");
                    double inches = Int32.Parse(Console.ReadLine());
                    double cm = 2.54 * inches;
                    Console.WriteLine(inches + " inches is = " + cm + " centimeters");
                    break;

                case "C":
                    Console.WriteLine("Enter the lbs to convert: ");
                    double lbs = Int32.Parse(Console.ReadLine());
                    double kg = 0.45359237 * lbs;
                    Console.WriteLine(lbs + " pounds is = " + kg + " kilograms");
                    break;

                case "D":
                    Console.WriteLine("Enter the km to convert: ");
                    double Km = Int32.Parse(Console.ReadLine());
                    double Miles = 0.62137119 * Km;
                    Console.WriteLine(Km + " kilometers is = " + Miles + " miles");
                    break;

                case "E":
                    Console.WriteLine("Enter the cm to convert: ");
                    double Cm = Int32.Parse(Console.ReadLine());
                    double Inches = 0.39 * Cm;
                    Console.WriteLine(Cm + " kilograms is = " + Inches + " pounds");  
                    break;

                case "F":
                    Console.WriteLine("Enter the kg to convert: ");
                    double Kg = Int32.Parse(Console.ReadLine());
                    double Lbs = 2.2 * Kg;
                    Console.WriteLine(Kg + " kilograms is = " + Lbs + " pounds");
                    break;

                default:
                    break;

                    

            }
                Console.ReadLine();
        }
    }
}
