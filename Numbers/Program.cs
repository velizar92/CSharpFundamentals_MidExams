using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> resultList = new List<int>();
            List<int> finalList = new List<int>();

            double averageNumber = 0.0;
            double sum = intArray.Sum();
         
            averageNumber = (sum / intArray.Length);

            for (int i = 0; i < intArray.Length; i++)
            {
                if(intArray[i] > averageNumber)
                {
                    resultList.Add(intArray[i]);
                } 
            }

            resultList.Sort();
            resultList.Reverse();

            if(resultList.Count < 5 && resultList.Count > 0) 
            {
                //output
                Console.WriteLine(string.Join(' ', resultList));
            }
            else if (resultList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int j = 0; j < 5; j++)
                {
                    finalList.Add(resultList[j]);
                }
                //output
                Console.WriteLine(string.Join(' ', finalList));
            }

            

        }
    }
}
