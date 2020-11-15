using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputParts = Console.ReadLine().Split('#').ToList();
            double water = int.Parse(Console.ReadLine());
            double totalEffort = 0;
            List<double> fireValues = new List<double>(); 

            for (int i = 0; i < inputParts.Count; i++)
            {
                string typeOfFire = inputParts[i].Trim().Split('=')[0].Trim();
                double value = double.Parse(inputParts[i].Trim().Split('=')[1].Trim());
                             
                if (water >= value && typeOfFire == "High" && (value >= 81 && value <= 125))
                {
                    fireValues.Add(value);
                    water -= value;                  
                    totalEffort += value * 0.25;
                }
                else if(water >= value && typeOfFire == "Medium" && (value >= 51 && value <= 80))
                {
                    fireValues.Add(value);
                    water -= value;
                    totalEffort += value * 0.25;
                }
                else if(water >= value && typeOfFire == "Low" && (value >= 1 && value <= 50))
                {
                    fireValues.Add(value);
                    water -= value;
                    totalEffort += value * 0.25;
                }
            }

            Console.WriteLine("Cells:");
           
            foreach(var item in fireValues)
            {
                Console.WriteLine("- " + item);
            }

            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {fireValues.Sum()}");


        }
    }
}
