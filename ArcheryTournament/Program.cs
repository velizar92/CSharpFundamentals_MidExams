using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split('|');
            int[] numbers = new int[line.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            int points = 0;
            int index = 0;
            int length = 0;



            string command = Console.ReadLine();
            string[] temp;                                                      //temp array to split the new line (by spaces)
            string[] indexes;                                                   //array to split the command and the indexes (by '@' separator)

            while (command != "Game over")
            {
                if (command == "Reverse")
                {
                    Array.Reverse(numbers);
                    command = Console.ReadLine();
                    continue;

                }
                temp = command.Split(); //split by spaces
                indexes = temp[1].Split('@'); //split by @

                if (indexes[0] == "Left")
                {
                    index = int.Parse(indexes[1]);
                    length = int.Parse(indexes[2]);

                    // if the index is valid
                    if (index >= 0 && index <= numbers.Length - 1)
                    {
                        //while we are going to the target index
                        while (length != 0)
                        {

                            if (index > 0) //if it's not on the first index
                            {
                                index--;
                                length--;
                            }
                            else if (index == 0) //if it's on the first index
                            {
                                index = numbers.Length - 1;
                                length--;
                            }
                        }
                        if (numbers[index] >= 5) //if there is enough points
                        {
                            numbers[index] -= 5;
                            points += 5;
                        }
                        else //if there isn't is enough points
                        {
                            points += numbers[index];
                            numbers[index] = 0;
                        }
                    }
                }
                else if (indexes[0] == "Right")
                {

                    index = int.Parse(indexes[1]);
                    length = int.Parse(indexes[2]);

                    // if the index is valid
                    if (index >= 0 && index <= numbers.Length - 1)
                    {
                        //while we are going to the target index
                        while (length != 0)
                        {
                            if (index < numbers.Length - 1)// if it's not on the last index
                            {
                                index++;
                                length--;
                            }
                            else if (index == numbers.Length - 1) //// if it's on the last index
                            {
                                index = 0;
                                length--;
                            }
                        }

                        if (numbers[index] >= 5)
                        {
                            numbers[index] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += numbers[index];
                            numbers[index] = 0;
                        }
                    }
                }

                command = Console.ReadLine();

            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + " - ");
            }

            Console.WriteLine(numbers[numbers.Length - 1]);

            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");


        }
    }
}
