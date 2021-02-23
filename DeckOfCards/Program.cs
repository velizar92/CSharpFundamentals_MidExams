using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputCardList = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> resultCardList = new List<string>();

            //TRIMMING OF SPACES: 
            foreach (var card in inputCardList)
            {
                resultCardList.Add(card.Trim());
            }

            int numberOfCommands = int.Parse(Console.ReadLine());
            string command = "";

            for (int i = 0; i < numberOfCommands; i++)
            {
                
                command = Console.ReadLine();

                string[] commandParts = command.Split(',').ToArray();
                string icomand = commandParts[0].Trim();

                //COMMANDS LOGIC: 
                if (icomand == "Add")
                {
                    string cardName = commandParts[1].Trim();
                    if (!resultCardList.Contains(cardName))
                    {
                        resultCardList.Add(cardName);
                        Console.WriteLine("Card successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }
                else if (icomand == "Remove")
                {
                    string cardName = commandParts[1].Trim();
                    if (!resultCardList.Contains(cardName))
                    {
                        Console.WriteLine("Card not found");
                    }
                    else
                    {
                        resultCardList.Remove(cardName);
                        Console.WriteLine("Card successfully sold");
                    }

                }
                else if (icomand == "Remove At")
                {                 
                    int index = int.Parse(commandParts[1].Trim());

                    if(index >= 0 && index <= resultCardList.Count - 1)   //IF INDEX IS VALID
                    {
                        resultCardList.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (icomand == "Insert")
                {
                    int index = int.Parse(commandParts[1]);
                    string cardName = commandParts[2].Trim();

                    if(index >= 0 && index <= resultCardList.Count - 1)
                    {
                        if(resultCardList.Contains(cardName))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                       else if (!resultCardList.Contains(cardName))
                        {
                            resultCardList.Insert(index, cardName);
                            Console.WriteLine("Card successfully bought");
                        }
                    }
                   else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            //OUTPUT:
            Console.WriteLine(string.Join(", ", resultCardList));
        }
    }
}
