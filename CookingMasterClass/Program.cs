using System;
using System.Reflection;

namespace CookingMasterClass
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFouerPerPackage = double.Parse(Console.ReadLine());
            double pricePerEgg = double.Parse(Console.ReadLine());
            double pricePerApron = double.Parse(Console.ReadLine());

            double student20Percents = Math.Ceiling(students * 0.20);

            int freePackages = 0;
            

            //For free packages only;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePackages++;
                }
            }

            double totalPriceAprons = pricePerApron * (students + student20Percents);
            double totalEggPrice = pricePerEgg * 10 * students;
            double totalFlouerPrice = priceFouerPerPackage * (students - freePackages);
            double totalPrice = totalPriceAprons + totalEggPrice + totalFlouerPrice;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else if(totalPrice > budget)
            {
                Console.WriteLine($"{totalPrice - budget:f2}$ more needed.");
            }

        }
    }
}
