using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {

                string inputString = Console.ReadLine();
                string[] lineParts = inputString.Split().ToArray();

                if(lineParts.Length == 1 && inputString == "End")
                {
                    break;
                }
                    
                string command = lineParts[0];
                int index = int.Parse(lineParts[1]);
                int value = int.Parse(lineParts[2]);
             
                if (command == "Shoot")
                {
                    if (index <= listNumbers.Count - 1 && index >= 0)              //power
                    {
                        listNumbers[index] -= value;
                        if (listNumbers[index] <= 0)
                        {
                            listNumbers.RemoveAt(index);
                        }
                    }
                }

                else if (command == "Add")
                {
                    if (index <= listNumbers.Count - 1 && index >= 0)           //value
                    {
                        listNumbers.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement! ");
                    }
                }

                else if (command == "Strike")
                {
                    if (index <= listNumbers.Count - 1 && index >= 0)         //radius
                    {
                        bool isValid = CheckRadius(listNumbers, value, index);
                        int element = listNumbers[index];

                        if(isValid == true)                                       //if radius is valid
                        {

                            for (int i = index - value; i < index + value; i++)
                            {
                                listNumbers.RemoveAt(i);
                               // listNumbers.Remove(element);
                            }

                            listNumbers.Remove(element);
                        }
                        else
                            Console.WriteLine("Strike missed!");
                    }
                }

            }

            //Output:
            Console.WriteLine(string.Join("|", listNumbers));

        }

       

       

        public static bool CheckRadius(List<int> listElements, int radius, int index)
        {
            if (index - radius >= 0 && index - radius <= listElements.Count - 1)
                return true;
            else
                return false;
        }


    }
}
