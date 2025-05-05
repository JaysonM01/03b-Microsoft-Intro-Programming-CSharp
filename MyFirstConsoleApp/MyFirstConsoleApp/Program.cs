using System;

class LibraryManager
{
    static void Main()
    {
        string[] books = new string[5];

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                AddBook(books);
            }
            else if (action == "remove")
            {
                RemoveBook(books);
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

    static void AddBook(string[] books)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i]))
            {
                Console.WriteLine("Enter the title of the book to add:");
                books[i] = Console.ReadLine();
                return;
            }
        }
        Console.WriteLine("The library is full. No more books can be added.");
    }

    static void RemoveBook(string[] books)
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string removeBook = Console.ReadLine();

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == removeBook)
            {
                books[i] = "";
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void DisplayBooks(string[] books)
    {
        Console.WriteLine("Available books:");
        foreach (string book in books)
        {
            if (!string.IsNullOrEmpty(book))
                Console.WriteLine(book);
        }
    }
}
