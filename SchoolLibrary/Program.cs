using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> books = Console.ReadLine().Split('&').ToList();


            while(true)
            {
                //input
                string inputLine = Console.ReadLine();

                if (inputLine == "Done")
                {
                    break;
                }

                string[] inputParts = inputLine.Split('|');

                if(inputParts.Length == 3)
                {
                    //SWAP COMMAND
                    string commandBook = inputParts[0].Trim(' '); ;
                    string bookOne = inputParts[1].Trim(' ');
                    string bookTwo = inputParts[2].Trim(' ');

                    if(commandBook == "Swap Books")
                    {
                        if (books.Contains(bookOne) && books.Contains(bookTwo))
                        {
                            Swap(books, books.IndexOf(bookOne), books.IndexOf(bookTwo));
                        }
                    }
                }

                if(inputParts.Length == 2)
                {
                    //SWAP COMMAND
                    string commandBook = inputParts[0].Trim(' ');
                    string bookItem = inputParts[1].Trim(' ');      //bookItem is "bookName" or "bookIndex"

                    if (commandBook == "Add Book")
                    {
                        if (!books.Contains(bookItem))
                        {
                            books.Insert(0, bookItem);
                        }      
                    }

                    else if(commandBook == "Take Book")
                    {
                        if (books.Contains(bookItem))
                        {
                            books.Remove(bookItem);
                        }
                    }

                    else if (commandBook == "Insert Book")
                    {
                        books.Add(bookItem);
                    }

                    else if (commandBook == "Check Book")
                    {
                        int index = int.Parse(bookItem);
                        if(index >= 0 && index <= books.Count -1)
                        {
                            Console.WriteLine(books[index]); //print the name of the book
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", books));
        }



        public static void Swap(List<string> list, int index1, int index2)
        {
            string temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }


    }
}
