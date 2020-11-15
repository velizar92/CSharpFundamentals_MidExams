using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {

            int adventureDays = int.Parse(Console.ReadLine());
            int countPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());

            //Per day
            double personWaterPerDay = double.Parse(Console.ReadLine());
            double personFoodPerDay = double.Parse(Console.ReadLine());


            double totalWater = adventureDays * countPlayers * personWaterPerDay;
            double totalFood = adventureDays * countPlayers * personFoodPerDay;

            double currentWater = totalWater;
            double currentFood = totalFood;

            for (int i = 1; i <= adventureDays; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    break;
                }
                if(i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    currentWater -= currentWater * 0.30;
                }
                if(i % 3 == 0)
                {
                    currentFood = currentFood - (currentFood / countPlayers);
                    groupEnergy += groupEnergy * 0.10;
                }
            }

            if(groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            if(groupEnergy <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {currentFood:f2} food and {currentWater:f2} water.");
            }





        }
    }
}
