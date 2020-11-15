using System;

namespace EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());

            double flourKgPrice = double.Parse(Console.ReadLine());
            double packEgsPrice = flourKgPrice * 0.75;
            double priceMilkLiter = flourKgPrice + (flourKgPrice * 0.25);
            int cozonacs = 0;
            int colloredEggs = 0;
            

            double totalPriceOneCozunac = flourKgPrice + packEgsPrice + (priceMilkLiter / 4);

            while (budget > 0)
            {
                if(budget < totalPriceOneCozunac)
                {                   
                    break;
                }
                //main logic
                cozonacs++;
                budget -= totalPriceOneCozunac;
                colloredEggs += 3;
                if (cozonacs % 3 == 0)
                {
                    int loosedEggs = cozonacs - 2;
                    colloredEggs -= loosedEggs;
                }
               
            }


            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {colloredEggs} eggs and {budget:f2}BGN left.");

        }
    }
}
