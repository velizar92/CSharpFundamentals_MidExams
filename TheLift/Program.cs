using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {

            int peopleWaitingForLyft = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int peopleOnTheCurrentWagon = 0;
            int peopleonTheLyft = 0;
            bool noMorePeople = false;                  //flag

            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4)
                {
                    wagons[i]++;
                    peopleOnTheCurrentWagon++;
                    if (peopleonTheLyft + peopleOnTheCurrentWagon == peopleWaitingForLyft)
                    {
                        noMorePeople = true;
                        break;
                    }
                }
                peopleonTheLyft += peopleOnTheCurrentWagon;
                if (noMorePeople)
                {
                    break;
                }
                peopleOnTheCurrentWagon = 0;
            }


            //Output conditions: 
            if (peopleWaitingForLyft > peopleonTheLyft)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaitingForLyft - peopleonTheLyft} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (peopleWaitingForLyft < wagons.Length * 4 && wagons.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (wagons.All(w => w == 4) && noMorePeople == true)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }






        }
    }
}
