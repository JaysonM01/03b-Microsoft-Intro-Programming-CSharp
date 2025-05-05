using System;

class LibraryManager
{
    static void Main()
    {
        string[] bookCollection = new string[5]; // Array to store book titles

        while (true)
        {
            Console.WriteLine("\nWould you like to add or remove a book? (add/remove/exit)");
            string userChoice = Console.ReadLine().ToLower();

            switch (userChoice)
            {
                case "add":
                    AddBook(bookCollection);
                    break;
                case "remove":
                    RemoveBook(bookCollection);
                    break;
                case "exit":
                    Console.WriteLine("Exiting the Library Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please type 'add', 'remove', or 'exit'.");
                    break;
            }

            DisplayBooks(bookCollection);
        }
    }

    /// <summary>
    /// Adds a new book to the library if space is available.
    /// </summary>
    static void AddBook(string[] books)
    {
        int emptyIndex = FindEmptySlot(books);
        if (emptyIndex == -1)
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
        }

        Console.WriteLine("Enter the title of the book to add:");
        books[emptyIndex] = Console.ReadLine();
        Console.WriteLine($"'{books[emptyIndex]}' has been added to the library.");
    }

    /// <summary>
    /// Removes a book from the library if it exists.
    /// </summary>
    static void RemoveBook(string[] books)
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string bookToRemove = Console.ReadLine();

        int bookIndex = FindBookIndex(books, bookToRemove);
        if (bookIndex == -1)
        {
            Console.WriteLine("Book not found.");
        }
        else
        {
            books[bookIndex] = "";
            Console.WriteLine($"'{bookToRemove}' has been removed from the library.");
        }
    }

    /// <summary>
    /// Displays all available books in the library.
    /// </summary>
    static void DisplayBooks(string[] books)
    {
        Console.WriteLine("\nAvailable books:");
        bool hasBooks = false;

        foreach (string book in books)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine($"- {book}");
                hasBooks = true;
            }
        }

        if (!hasBooks)
        {
            Console.WriteLine("The library is empty.");
        }
    }

    /// <summary>
    /// Finds the first empty slot in the book array.
    /// </summary>
    /// <returns>Index of an empty slot, or -1 if the library is full.</returns>
    static int FindEmptySlot(string[] books)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i]))
                return i;
        }
        return -1;
    }

    /// <summary>
    /// Finds the index of a book in the array.
    /// </summary>
    /// <returns>Index of the book if found, or -1 if not found.</returns>
    static int FindBookIndex(string[] books, string bookTitle)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == bookTitle)
                return i;
        }
        return -1;
    }
}