using System;

class LibraryManager
{
    static void Main()
    {
        string[] bookCollection = new string[5]; // Library book storage
        string[] borrowedBooks = new string[3]; // Tracks borrowed books (max 3)

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do? (add/remove/search/borrow/return/exit)");
            string userChoice = Console.ReadLine().ToLower();

            switch (userChoice)
            {
                case "add":
                    AddBook(bookCollection);
                    break;
                case "remove":
                    RemoveBook(bookCollection);
                    break;
                case "search":
                    SearchBook(bookCollection);
                    break;
                case "borrow":
                    BorrowBook(bookCollection, borrowedBooks);
                    break;
                case "return":
                    ReturnBook(borrowedBooks);
                    break;
                case "exit":
                    Console.WriteLine("Exiting the Library Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please type 'add', 'remove', 'search', 'borrow', 'return', or 'exit'.");
                    break;
            }

            DisplayBooks(bookCollection);
            DisplayBorrowedBooks(borrowedBooks);
        }
    }

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

    static void SearchBook(string[] books)
    {
        Console.WriteLine("Enter the title of the book to search:");
        string bookToSearch = Console.ReadLine();

        int bookIndex = FindBookIndex(books, bookToSearch);
        Console.WriteLine(bookIndex == -1 
            ? $"'{bookToSearch}' is not in the library collection."
            : $"'{bookToSearch}' is available in the library.");
    }

    static void BorrowBook(string[] books, string[] borrowedBooks)
    {
        if (FindEmptySlot(borrowedBooks) == -1)
        {
            Console.WriteLine("You have reached your borrowing limit of 3 books.");
            return;
        }

        Console.WriteLine("Enter the title of the book to borrow:");
        string bookToBorrow = Console.ReadLine();

        int bookIndex = FindBookIndex(books, bookToBorrow);
        if (bookIndex == -1 || string.IsNullOrEmpty(books[bookIndex]))
        {
            Console.WriteLine("Book not available for borrowing.");
            return;
        }

        books[bookIndex] = ""; // Remove from library
        borrowedBooks[FindEmptySlot(borrowedBooks)] = bookToBorrow; // Add to borrowed books
        Console.WriteLine($"You have borrowed '{bookToBorrow}'.");
    }

    static void ReturnBook(string[] borrowedBooks)
    {
        Console.WriteLine("Enter the title of the book to return:");
        string bookToReturn = Console.ReadLine();

        int bookIndex = FindBookIndex(borrowedBooks, bookToReturn);
        if (bookIndex == -1)
        {
            Console.WriteLine("This book is not in your borrowed list.");
            return;
        }

        borrowedBooks[bookIndex] = "";
        Console.WriteLine($"You have returned '{bookToReturn}'.");
    }

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
        if (!hasBooks) Console.WriteLine("The library is empty.");
    }

    static void DisplayBorrowedBooks(string[] borrowedBooks)
    {
        Console.WriteLine("\nYour borrowed books:");
        bool hasBorrowedBooks = false;
        foreach (string book in borrowedBooks)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine($"- {book}");
                hasBorrowedBooks = true;
            }
        }
        if (!hasBorrowedBooks) Console.WriteLine("You have not borrowed any books.");
    }

    static int FindEmptySlot(string[] books)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i])) return i;
        }
        return -1;
    }

    static int FindBookIndex(string[] books, string bookTitle)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == bookTitle) return i;
        }
        return -1;
    }
}