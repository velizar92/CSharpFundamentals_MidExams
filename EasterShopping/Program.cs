using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> shops = Console.ReadLine().Split().ToList();
            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string command = Console.ReadLine();

                string[] commandParts = command.Split().ToArray();

                if (commandParts.Length == 2)
                {
                    string i_command = commandParts[0].Trim();
                    string shop = commandParts[1].Trim();

                    if (i_command == "Include")
                    {
                        shops.Add(shop);
                    }
                }
                else if (commandParts.Length == 3)
                {
                    if (commandParts[0] == "Visit")
                    {
                        string flag = commandParts[1];
                        int numberOfShops = int.Parse(commandParts[2]);

                        if(shops.Count >= numberOfShops) //valid condition
                        {
                            if(flag == "first")
                            {
                                for (int j = 0; j < numberOfShops; j++)
                                {
                                    shops.RemoveAt(0);
                                }
                            }
                            else if(flag == "last")
                            {
                                shops.Reverse();
                                for (int k = 0; k < numberOfShops; k++)
                                {
                                    shops.RemoveAt(0);
                                }
                                shops.Reverse();
                            }
                        }
                    }

                    else if (commandParts[0] == "Prefer")
                    {
                        int shopIndexOne = int.Parse(commandParts[1]);
                        int shopIndexTwo = int.Parse(commandParts[2]);

                        if((shopIndexOne >= 0 && shopIndexOne < shops.Count) && (shopIndexTwo >= 0 && shopIndexTwo < shops.Count))
                        {
                            string tempShop = shops[shopIndexOne];
                            shops[shopIndexOne] = shops[shopIndexTwo];
                            shops[shopIndexTwo] = tempShop;                  //exchanging
                        }

                    }
                    else if (commandParts[0] == "Place")
                    {
                        string shop = commandParts[1];
                        int index = int.Parse(commandParts[2]);

                        if (index + 1 >= 0 && (index + 1) < shops.Count)
                            shops.Insert(index + 1, shop);
                    }
                }
            }

            //Output:
            Console.WriteLine("Shops left: ");
            Console.WriteLine(string.Join(' ', shops)); 
                




        }
    }
}
