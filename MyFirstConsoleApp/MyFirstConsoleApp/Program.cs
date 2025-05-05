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

            Console.WriteLine("\nChoose an action:");
            if (books.Count < maxBooks) Console.WriteLine("'add' - Add books continuously");
            if (books.Count > 0) Console.WriteLine("'remove' - Remove books continuously");
            Console.WriteLine("'exit' - Exit program");
            Console.Write("Enter your choice: ");

            string choice;
            while (true)
            {
                choice = Console.ReadLine().ToLower();
                if ((choice == "add" && books.Count < maxBooks) || (choice == "remove" && books.Count > 0) || choice == "exit")
                    break;
                else
                    Console.Write("Invalid input. Please enter a valid option: ");
            }

            switch (choice)
            {
                case "add":
                    AddBooks();
                    break;
                case "remove":
                    RemoveBooks();
                    break;
                case "exit":
                    running = false;
                    Console.WriteLine("Goodbye!");
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