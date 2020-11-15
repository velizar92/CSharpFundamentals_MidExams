using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            while(true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;                                                      //exit from the while loop
                }

                else if(command == "decrease")
                {
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        intArray[i] -= 1;                                       //decrease each element in the array with 1
                    }
                }
                else
                {
                    string[] commandParts = command.Split().ToArray();
                    string commandPart = commandParts[0];
                    int firstIndex = int.Parse(commandParts[1]);
                    int secondIndex = int.Parse(commandParts[2]);

                    if (commandParts[0] == "multiply")
                    {
                        int multiResult = intArray[firstIndex] * intArray[secondIndex];
                        intArray[firstIndex] = multiResult;
                    }
                    else if(commandParts[0] == "swap")
                    {
                        int tempElemet = intArray[secondIndex]; //get 87
                        intArray[secondIndex] = intArray[firstIndex];
                        intArray[firstIndex] = tempElemet; //swap
                    }
                }
              
            }

            //output:
            Console.WriteLine(string.Join(", ", intArray));

        }
    }
}
