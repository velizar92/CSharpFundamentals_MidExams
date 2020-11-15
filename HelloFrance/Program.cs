using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split('|').ToList();
            double budget = double.Parse(Console.ReadLine());

            List<double> prices = new List<double>();
            double profit = 0.00;



            for (int i = 0; i < input.Count; i++)
            {
                string itemType = input[i].Split("->")[0];
                double price = double.Parse(input[i].Split("->").Last());

                if (itemType == "Clothes" && price <= 50.00 && budget - price >= 0) // 3 checks = 1: Type, 2: Price, 3: Available Money
                {
                    budget -= price;
                    profit += price * 0.40;
                    prices.Add(price * 1.40);
                }
                else if (itemType == "Shoes" && price <= 35.00 && budget - price >= 0) // 3 checks = 1: Type, 2: Price, 3: Available Money
                {
                    budget -= price;
                    profit += price * 0.40;
                    prices.Add(price * 1.40);
                }
                else if (itemType == "Accessories" && price <= 20.50 && budget - price >= 0) // 3 checks = 1: Type, 2: Price, 3: Available Money
                {
                    budget -= price;
                    profit += price * 0.40;
                    prices.Add(price * 1.40);
                }
            }

            
            //Output:

            foreach (var item in prices)
            {
                Console.Write($"{item:F2} ");
            }

            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:F2}");

            if (budget + prices.Sum() >= 150.00)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

        }
    }
}
