using System;
using System.Collections.Generic;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while(true)
            {
                string command = Console.ReadLine().Trim();
                if (command == "END")
                {
                    break;
                }
                else if (command == "Reverse")
                {
                    numberList.Reverse();
                }
                else
                {
                    string[] commandParts = command.Split().ToArray();

                    if (commandParts.Length == 3)
                    {
                        string icommand = commandParts[0].Trim();
                        if (icommand == "Change")
                        {
                            int paintNumber = int.Parse(commandParts[1]);
                            int changedNumber = int.Parse(commandParts[2]);
                            if (numberList.Contains(paintNumber))
                            {                                
                                var index = numberList.IndexOf(paintNumber);
                                numberList[index] = changedNumber;                             
                            }
                        }

                        else if (icommand == "Switch")
                        {
                            int paintNumber = int.Parse(commandParts[1]);
                            int paintNumberTwo = int.Parse(commandParts[2]);

                            if(numberList.Contains(paintNumber) && numberList.Contains(paintNumberTwo))
                            {
                                int indexOne = numberList.IndexOf(paintNumber);
                                int indexTwo = numberList.IndexOf(paintNumberTwo);
                                var temp = numberList[indexOne];
                                numberList[indexOne] = numberList[indexTwo];
                                numberList[indexTwo] = temp;
                            }
                        }

                        else if (icommand == "Insert")
                        {
                            int place = int.Parse(commandParts[1]);
                            int paintNumberTwo = int.Parse(commandParts[2]);
                            if(place + 1 >= 0 && place + 1 < numberList.Count - 1)
                            {
                                numberList.Insert(place + 1, paintNumberTwo);
                            }

                        }
                    }

                    else if (commandParts.Length == 2)
                    {
                        string icommand = commandParts[0];
                        if (icommand == "Hide")
                        {
                            int paintNumber = int.Parse(commandParts[1]);
                            if(numberList.Contains(paintNumber))
                            {
                                for (int i = 0; i < numberList.Count; i++)
                                {
                                    if(numberList[i] == paintNumber)
                                    numberList.Remove(numberList[i]);
                                }
                            }
                        }
                    }

                }                   //end else
            }                       //end while loop


            //Output:
            Console.WriteLine(string.Join(' ', numberList));


        }
    }
}
