using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhoodsList = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            int countValentineDay = 0;
            int cupidLastPosition = 0;

            while (true)
            {

                string rawInput = Console.ReadLine();

                if (rawInput == "Love!")
                {
                    break;
                }
                //-------------PARSING--------------
                string[] inputLine = rawInput.Split().ToArray();

                string command = inputLine[0];
                int jumpIndex = int.Parse(inputLine[1]);


                //----------------MAIN LOGIC---------------------
                if ((cupidLastPosition + jumpIndex >= 0) && (cupidLastPosition + jumpIndex <= neighborhoodsList.Count - 1) && neighborhoodsList[cupidLastPosition + jumpIndex] != 0)
                {
                    neighborhoodsList[jumpIndex + cupidLastPosition] -= 2;

                    if (neighborhoodsList[jumpIndex + cupidLastPosition] <= 0)
                    {
                        Console.WriteLine($"Place {jumpIndex + cupidLastPosition} has Valentine's day.");
                        countValentineDay++;
                    }
                    cupidLastPosition += jumpIndex;
                }


                else if ((cupidLastPosition + jumpIndex >= 0) && (cupidLastPosition + jumpIndex <= neighborhoodsList.Count - 1) && neighborhoodsList[cupidLastPosition + jumpIndex] == 0)
                {
                    Console.WriteLine($"Place {jumpIndex + cupidLastPosition} already had Valentine's day.");
                    cupidLastPosition += jumpIndex;
                }
              
                else if (cupidLastPosition + jumpIndex > neighborhoodsList.Count - 1)
                {
                    cupidLastPosition = 0;
                    jumpIndex = 0;

                    if (neighborhoodsList[0] <= 0)
                    {
                        Console.WriteLine($"Place 0 already had Valentine's day.");
                       
                    }
                    else
                    {
                        neighborhoodsList[0] -= 2;
                        if (neighborhoodsList[0] <= 0)
                        {
                            Console.WriteLine("Place 0 has Valentine's day.");
                            countValentineDay++;
                        }
                        cupidLastPosition = 0;
                    }

                }

      
            }



            //-----------------------OUTPUT:---------------------

            Console.WriteLine($"Cupid's last position was {cupidLastPosition}.");

            if (neighborhoodsList.Count == countValentineDay)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {Math.Abs(neighborhoodsList.Count - countValentineDay)} places.");
            }





            //List<int> listOfHouses = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            //int currentHouse = 0;
            //string command = string.Empty;
            //while ((command = Console.ReadLine()) != "Love!")
            //{
            //    string[] commandArray = command.Split().ToArray();
            //    if (commandArray[0] == "Jump")
            //    {
            //        int jumpLength = int.Parse(commandArray[1]);
            //        if (currentHouse + jumpLength >= 0 && currentHouse + jumpLength <= listOfHouses.Count - 1 && listOfHouses[currentHouse + jumpLength] != 0)
            //        {
            //            listOfHouses[currentHouse + jumpLength] = listOfHouses[currentHouse + jumpLength] - 2;

            //            if (listOfHouses[currentHouse + jumpLength] == 0)
            //            {
            //                Console.WriteLine($"Place {currentHouse + jumpLength} has Valentine's day.");
            //            }

            //            currentHouse += jumpLength;
            //        }

            //        else if (currentHouse + jumpLength >= 0 && currentHouse + jumpLength <= listOfHouses.Count - 1 && listOfHouses[currentHouse + jumpLength] == 0)
            //        {
            //            Console.WriteLine($"Place {currentHouse + jumpLength} already had Valentine's day.");
            //            currentHouse += jumpLength;
            //        }

            //        else if (currentHouse + jumpLength > listOfHouses.Count - 1)
            //        {
            //            jumpLength = 0;
            //            currentHouse = 0;
            //            if (listOfHouses[jumpLength] == 0)
            //            {
            //                Console.WriteLine($"Place {jumpLength} already had Valentine's day.");
            //            }
            //            else
            //            {
            //                listOfHouses[jumpLength] = listOfHouses[jumpLength] - 2;
            //                if (listOfHouses[jumpLength] == 0)
            //                {
            //                    Console.WriteLine($"Place {jumpLength} has Valentine's day.");
            //                }

            //                currentHouse += jumpLength;
            //            }
            //        }
            //    }
            //}


            ////OUTPUT
            //Console.WriteLine($"Cupid's last position was {currentHouse}.");
            //if (listOfHouses.Sum() == 0)
            //{
            //    Console.WriteLine($"Mission was successful.");
            //}

            //else 
            //{
            //    int countHouseWithoutValentinsDay = 0;
            //    for (int i = 0; i < listOfHouses.Count; i++)
            //    {
            //        if (listOfHouses[i] > 0)
            //            countHouseWithoutValentinsDay++;
            //    }

            //    Console.WriteLine($"Cupid has failed {countHouseWithoutValentinsDay} places.");
            //}




        }
    }
}
