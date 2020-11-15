using System;

namespace DisneyLandJourney
{
    class Program
    {
        static void Main(string[] args)
        {

            double realJurneyCost = double.Parse(Console.ReadLine());
            double collectedMoney = 0.0;                                

            int months = int.Parse(Console.ReadLine());


            for (int i = 1; i <= months; i++)       
            {
                
                if (i % 2 != 0 && i != 1)
                {
                    collectedMoney -= (collectedMoney * 0.16);                           
                }
                else if(i % 4 == 0)
                {
                    collectedMoney += (collectedMoney * 0.25);
                }

                collectedMoney += (realJurneyCost * 0.25);
            }

            //Output:

            if(collectedMoney > realJurneyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {collectedMoney - realJurneyCost:f2}lv. for souvenirs.");
            }
            else if(collectedMoney < realJurneyCost)
            {
                Console.WriteLine($"Sorry. You need {realJurneyCost - collectedMoney:f2}lv. more.");
            }
            Console.WriteLine();




        }
    }
}
