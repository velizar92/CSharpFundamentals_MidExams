using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(' ').ToList();
            int numberMoves = 0;
            int hitsCounter = 0;
            int uniqueElements = inputList.Count / 2;

           

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split(' ').ToArray();
                int indexOne = int.Parse(commandParts[0]);
                int indexTwo = int.Parse(commandParts[1]);

                if (indexOne == indexTwo || (indexOne < 0 || indexOne > inputList.Count - 1) || (indexTwo < 0 || indexTwo > inputList.Count - 1))
                {
                    numberMoves++;
                    inputList.Insert(inputList.Count / 2, "-" + numberMoves + "a");
                    inputList.Insert(inputList.Count / 2, "-" + numberMoves + "a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (inputList[indexOne] == inputList[indexTwo])
                    {
                        string tempVarIndex = inputList[indexOne];
                        Console.WriteLine($"Congrats! You have found matching elements - {inputList[indexOne]}!");

                        while (inputList.Contains(tempVarIndex))
                        {
                            inputList.Remove(tempVarIndex);
                        }

                        numberMoves++;
                        hitsCounter++;
                    }
                    else if (inputList[indexOne] != inputList[indexTwo])
                    {
                        Console.WriteLine("Try again!");
                        numberMoves++;
                    }
                }

                if (hitsCounter == uniqueElements)
                {
                    Console.WriteLine($"You have won in {numberMoves} turns!");
                    break;
                }               
            }

            if (hitsCounter < uniqueElements)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', inputList));
            }

        }
    }
}
