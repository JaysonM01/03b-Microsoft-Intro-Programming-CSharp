using System;
using System.Collections.Generic;

class Library
{
    static List<string> books = new List<string>();
    static int maxBooks = 5;

    static void Main()
    {
        Console.WriteLine("Welcome to the Library!");

        bool running = true;
        while (running)
        {
            DisplayBooks();
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBooks(); // Continuous adding mode
                    break;
                case "2":
                    RemoveBooks(); // Continuous removal mode
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }

    static void AddBooks()
    {
        while (books.Count < maxBooks)
        {
            Console.Write("\nEnter a book title to add (or type 'exit' to stop): ");
            string bookTitle = Console.ReadLine();

            if (bookTitle.ToLower() == "exit")
                break;

            books.Add(bookTitle);
            Console.WriteLine($"'{bookTitle}' has been added to the library.");

            if (books.Count == maxBooks)
            {
                Console.WriteLine("Library is now full! No more books can be added.");
                break;
            }
        }
    }

    static void RemoveBooks()
    {
        while (books.Count > 0)
        {
            Console.Write("\nEnter the title of the book to remove (or type 'exit' to stop): ");
            string removeTitle = Console.ReadLine();

            if (removeTitle.ToLower() == "exit")
                break;

            if (books.Remove(removeTitle))
            {
                Console.WriteLine($"'{removeTitle}' has been removed from the library.");
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }

            if (books.Count == 0)
            {
                Console.WriteLine("Library is now empty.");
                break;
            }
        }
    }

    static void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Collection:");
        if (books.Count == 0)
        {
            Console.WriteLine("The library is empty.");
        }
        else
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }
    }
}