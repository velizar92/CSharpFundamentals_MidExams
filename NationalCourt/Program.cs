using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {


            byte empOneEfficiency = byte.Parse(Console.ReadLine());
            byte empTwoEfficiency = byte.Parse(Console.ReadLine());
            byte empThreeEfficiency = byte.Parse(Console.ReadLine());

            int peopleEffPerHour = empOneEfficiency + empTwoEfficiency + empThreeEfficiency;

            int peopleCount = int.Parse(Console.ReadLine());          
            int hours = 0;

            while (peopleCount > 0)
            {
                peopleCount -= peopleEffPerHour;
                hours++;
                if (hours % 4 == 0) 
                {
                    hours++;                    
                }
            }

            Console.WriteLine($"Time needed: {hours}h. ");


        }
    }
}
