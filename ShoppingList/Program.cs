using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> groceriesList = Console.ReadLine().Split('!').ToList();

            while (true)
            {

                string rawInput = Console.ReadLine();
                
                if(rawInput == "Go Shopping!")
                {
                    break;
                }

                string[] inputLine = rawInput.Split().ToArray();

                if(inputLine.Length == 2)
                {
                    string command = inputLine[0];
                    string item = inputLine[1];


                    if (command == "Urgent")
                    {
                        if (!groceriesList.Contains(item))
                        {
                            groceriesList.Insert(0, item);
                        }
                    }

                    if (command == "Unnecessary")
                    {
                        if (groceriesList.Contains(item))
                        {
                            groceriesList.Remove(item);
                        }
                    }


                    else if (command == "Rearrange")
                    {
                        if(groceriesList.Contains(item))
                        {
                            groceriesList.Remove(item);
                            groceriesList.Add(item);
                        }
                    }
                }


                else if(inputLine.Length == 3)
                {

                    string command = inputLine[0];
                    string oldItem = inputLine[1];
                    string newItem = inputLine[2];

                    if (command == "Correct")
                    {
                        if (groceriesList.Contains(oldItem))
                        {
                            int index = groceriesList.IndexOf(oldItem);
                            groceriesList.Insert(index, newItem);
                            groceriesList.RemoveAt(index + 1);
                        }
                    }    
                }
            }


            Console.WriteLine(string.Join(", ", groceriesList));


        }
    }
}
