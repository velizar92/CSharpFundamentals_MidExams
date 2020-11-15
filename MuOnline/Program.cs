using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] rooms = Console.ReadLine().Split('|').ToArray();
            int initHealth = 100;
            int temphealth = 100;
            int roomCounter = 0;
            int bitcoins = 0;
            
            for (int i = 0; i < rooms.Length; i++)
            {

                string command = rooms[i].Split(' ')[0];
                int number =int.Parse(rooms[i].Split(' ')[1]);
                roomCounter++;

                if (command == "potion")
                {
                    temphealth += number;
                    if(temphealth >= initHealth)
                    {
                        Console.WriteLine($"You healed for 0 hp.");
                        Console.WriteLine($"Current health: {initHealth} hp.");
                        temphealth = 100;
                    }
                    else if(temphealth < initHealth)
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {temphealth} hp.");
                    }                 
                }
                
                else if(command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }

                //Atack from monster
                else
                {
                    temphealth -= number;
                    if(temphealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else if(temphealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.\n" +
                            $"Best room: {i+1}");
                        break;
                    }
                }  
            } 


            if(roomCounter == rooms.Length)
            {
                Console.WriteLine("You've made it! ");
                Console.WriteLine($"Bitcoins {bitcoins}");
                Console.WriteLine($"Health {temphealth}");
            }



        }
    }
}
