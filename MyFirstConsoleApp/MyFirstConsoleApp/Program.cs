using System;
using System.Collections.Generic;

class LibraryManager
{
    static void Main()
    {
        List<string> books = new List<string>();
        const int maxCapacity = 5; // Maximum number of books allowed

        while (true)
        {
            Console.WriteLine("\nWould you like to add or remove a book? (add/remove/exit)");
            string action = GetValidInput();

            if (action == "add")
            {
                if (books.Count >= maxCapacity)
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                    continue;
                }

                Console.WriteLine("Enter the title of the book to add:");
                string newBook = GetValidInput();

                if (books.Contains(newBook))
                {
                    Console.WriteLine("This book is already in the library.");
                }
                else
                {
                    books.Add(newBook);
                    Console.WriteLine($"'{newBook}' has been added to the library.");
                }
            }
            else if (action == "remove")
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("The library is empty. No books to remove.");
                    continue;
                }

                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = GetValidInput();

                if (books.Remove(removeBook))
                {
                    Console.WriteLine($"'{removeBook}' has been removed from the library.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            DisplayBooks(books);
        }
    }

    static string GetValidInput()
    {
        string input;
        do
        {
            input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid value:");
            }
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    static void DisplayBooks(List<string> books)
    {
        Console.WriteLine("\nAvailable books:");
        if (books.Count == 0)
        {
            Console.WriteLine("The library is empty.");
        }
        else
        {
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }
        Console.WriteLine(); // Adds spacing for readability
    }
}