using System;
using System.Collections.Generic;
using System.Linq;

namespace SugarCubes
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while(true)
            {
                string command = Console.ReadLine();

                if(command == "Mort")
                {
                    break;
                }

                string[] commandParts = command.Split().ToArray();
                

                if(commandParts.Length == 3)
                {
                    string icommand = commandParts[0];
                    int value = int.Parse(commandParts[1]);
                    int replacement = int.Parse(commandParts[2]);

                    if(icommand == "Replace")
                    {
                        //var firstMatch = inputList.FirstOrDefault(s => s == value);
                        int index = inputList.IndexOf(value);
                        inputList[index] = replacement;

                    }
                }

                else if(commandParts.Length == 2)
                {
                    string icommand = commandParts[0];
                    int value = int.Parse(commandParts[1]);

                    if(icommand == "Add")
                    {
                        inputList.Add(value);
                    }
                    else if(icommand == "Remove")
                    {
                        inputList.Remove(value);
                    }
                    else if (icommand == "Collapse")
                    {
                        inputList.RemoveAll(x => x < value);
                    }
                }
            }

            //output:
            Console.WriteLine(string.Join(' ', inputList));




        }
    }
}
