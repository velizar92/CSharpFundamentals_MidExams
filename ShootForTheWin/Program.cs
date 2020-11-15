using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool[] shotsArray = new bool[arrayNumbers.Length];
            int shootedTargets = 0;
            int tempNumber = 0;

            string input = Console.ReadLine();


            while(input != "End")
            {

                int index = int.Parse(input); 

                if((index <= arrayNumbers.Length - 1) && index >= 0 && shotsArray[index] != true)
                {

                    tempNumber = arrayNumbers[index];
                    arrayNumbers[index] = -1;                  
                    shotsArray[index] = true;
                    shootedTargets++;
           
                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        if (i != index && arrayNumbers[i] > tempNumber && shotsArray[i] != true)
                        {
                            arrayNumbers[i] -= tempNumber;
                        }
                        else if(i != index && arrayNumbers[i] <= tempNumber && shotsArray[i] != true)
                        {
                            arrayNumbers[i] += tempNumber;
                        }                    
                    }
                }


                //Absolute NECESSARY
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootedTargets} -> {string.Join(" ", arrayNumbers)}"); //100 POINTS

        }
    }
}
