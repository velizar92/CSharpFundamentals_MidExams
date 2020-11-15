using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> gifts = Console.ReadLine().Split(' ', System.StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";

            while (true)
            {
                command = Console.ReadLine();
                if(command == "No Money" || command == "no money" || command == "NO MONEY")
                {
                    break;
                }
                string[] commandParts = command.Split(' ', System.StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandParts.Length == 3)
                {
                    string i_command = commandParts[0].Trim();
                    if(i_command == "Required")
                    {
                        string gift = commandParts[1].Trim();
                        int index = int.Parse(commandParts[2].Trim());

                        if (index > -1 && index < gifts.Count)
                        {
                            gifts[index] = gift;
                        }
                    } 
                }
                else if(commandParts.Length == 2)
                {
                    string i_command = commandParts[0].Trim();
                    string gift = commandParts[1].Trim();

                    if (i_command == "OutOfStock")
                    {
                        if (gifts.Count > 0)
                        {
                            for (int i = 0; i < gifts.Count; i++)
                            {                              
                                if (gifts[i] == gift)
                                {
                                    gifts[i] = "None";                                
                                }
                            }
                        }
                    }
                    else if (i_command == "JustInCase")
                    {
                        gifts[gifts.Count - 1] = gift;
                    }
                }        
            }

            if(gifts.Count > 0)
            {
                for (int j = 0; j < gifts.Count; j++)
                {
                    if (gifts[j] == "None")
                    {
                        gifts.RemoveAt(j);
                    }
                }

                Console.WriteLine(string.Join(' ', gifts));
            }
           




        }
    }
}
