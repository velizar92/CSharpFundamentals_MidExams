using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }
                else if (command == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                string[] commandParts = command.Split().ToArray();
                if (commandParts.Length == 3)
                {
                    string icommand = commandParts[0];
                    if (icommand == "Swap")
                    {
                        string wordOne = commandParts[1];
                        string wordTwo = commandParts[2];
                        if (words.Contains(wordOne) && words.Contains(wordTwo))
                        {
                            int indexOne = words.IndexOf(wordOne);
                            int indexTwo = words.IndexOf(wordTwo);
                            string tempWord = words[indexOne];
                            words[indexOne] = words[indexTwo];
                            words[indexTwo] = tempWord;
                        }
                    }
                    else if (icommand == "Put")
                    {
                        string word = commandParts[1];
                        int index = int.Parse(commandParts[2]);

                        if(index - 1 > 0 && index - 1 < words.Count)
                        {
                            words.Insert(index - 1, word);
                        }
                        else if(index == 0)
                        {
                            words.Add(word);
                        }
                    }
                    else if (icommand == "Replace")
                    {
                        string wordOne = commandParts[1];
                        string wordTwo = commandParts[2];

                        if (words.Contains(wordTwo))
                        {
                            int index = words.IndexOf(wordTwo);
                            words[index] = wordOne;
                        }
                    }
                }
                else if (commandParts.Length == 2)
                {
                    string icommand = commandParts[0];
                    int index = int.Parse(commandParts[1]);
                    if (icommand == "Delete")
                    {
                        if (index + 1 > 0 && index + 1 < words.Count)
                        {
                            words.RemoveAt(index + 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', words));

        }
    }
}
