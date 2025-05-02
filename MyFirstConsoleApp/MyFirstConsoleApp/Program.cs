using System;

class Library
{
    // Variables to store book titles
    static string book1 = "";
    static string book2 = "";
    static string book3 = "";
    static string book4 = "";
    static string book5 = "";

    static void Main()
    {
        Console.WriteLine("Welcome to the Library!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. View books");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    RemoveBook();
                    break;
                case "3":
                    DisplayBooks();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter a book title to add: ");
        string bookTitle = Console.ReadLine();

        if (string.IsNullOrEmpty(book1))
            book1 = bookTitle;
        else if (string.IsNullOrEmpty(book2))
            book2 = bookTitle;
        else if (string.IsNullOrEmpty(book3))
            book3 = bookTitle;
        else if (string.IsNullOrEmpty(book4))
            book4 = bookTitle;
        else if (string.IsNullOrEmpty(book5))
            book5 = bookTitle;
        else
        {
            Console.WriteLine("No more books can be added. The library is full!");
            return;
        }

        Console.WriteLine($"'{bookTitle}' has been added to the library.");
    }

    static void RemoveBook()
    {
        Console.Write("Enter the title of the book to remove: ");
        string removeTitle = Console.ReadLine();

        if (removeTitle == book1)
            book1 = "";
        else if (removeTitle == book2)
            book2 = "";
        else if (removeTitle == book3)
            book3 = "";
        else if (removeTitle == book4)
            book4 = "";
        else if (removeTitle == book5)
            book5 = "";
        else
        {
            Console.WriteLine("Book not found in the library.");
            return;
        }

        Console.WriteLine($"'{removeTitle}' has been removed from the library.");
    }

    static void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Collection:");
        if (!string.IsNullOrEmpty(book1)) Console.WriteLine($"1. {book1}");
        if (!string.IsNullOrEmpty(book2)) Console.WriteLine($"2. {book2}");
        if (!string.IsNullOrEmpty(book3)) Console.WriteLine($"3. {book3}");
        if (!string.IsNullOrEmpty(book4)) Console.WriteLine($"4. {book4}");
        if (!string.IsNullOrEmpty(book5)) Console.WriteLine($"5. {book5}");

        if (string.IsNullOrEmpty(book1) && string.IsNullOrEmpty(book2) &&
            string.IsNullOrEmpty(book3) && string.IsNullOrEmpty(book4) &&
            string.IsNullOrEmpty(book5))
        {
            Console.WriteLine("The library is empty.");
        }
    }
}
