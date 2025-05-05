using System;

class LibraryManager
{
    static void Main()
    {
        string[] bookCollection = new string[5]; // Library storage
        string[] borrowedBooks = new string[3];  // Tracks borrowed books (max 3)
        bool[] checkedOutBooks = new bool[5];    // Tracks if books are checked out

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do? (add/remove/search/borrow/checkin/exit)");
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
                    BorrowBook(bookCollection, borrowedBooks, checkedOutBooks);
                    break;
                case "checkin":
                    CheckInBook(bookCollection, borrowedBooks, checkedOutBooks);
                    break;
                case "exit":
                    Console.WriteLine("Exiting the Library Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please type 'add', 'remove', 'search', 'borrow', 'checkin', or 'exit'.");
                    break;
            }

            DisplayBooks(bookCollection);
            DisplayBorrowedBooks(borrowedBooks);
            DisplayCheckedStatus(bookCollection,checkedOutBooks);
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

    static void BorrowBook(string[] books, string[] borrowedBooks, bool[] checkedOutBooks)
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
        checkedOutBooks[bookIndex] = true; // Mark book as checked out
        borrowedBooks[FindEmptySlot(borrowedBooks)] = bookToBorrow; // Add to borrowed books
        Console.WriteLine($"You have borrowed '{bookToBorrow}'.");
    }

    static void CheckInBook(string[] books, string[] borrowedBooks, bool[] checkedOutBooks)
    {
        Console.WriteLine("Enter the title of the book to check in:");
        string bookToCheckIn = Console.ReadLine();

        int borrowedIndex = FindBookIndex(borrowedBooks, bookToCheckIn);
        if (borrowedIndex == -1)
        {
            Console.WriteLine("This book is not in your borrowed list.");
            return;
        }

        borrowedBooks[borrowedIndex] = ""; // Remove from borrowed list
        int libraryIndex = FindEmptySlot(books); // Find an empty spot in the library

        if (libraryIndex != -1)
        {
            books[libraryIndex] = bookToCheckIn; // Restore book to the library
            checkedOutBooks[libraryIndex] = false; // Mark as checked in
            Console.WriteLine($"'{bookToCheckIn}' has been returned and checked in successfully.");
        }
        else
        {
            Console.WriteLine("The library is full. The book could not be checked in.");
        }
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

    static void DisplayCheckedStatus(string[] books, bool[] checkedOutBooks)
    {
        Console.WriteLine("\nLibrary Book Status:");
        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]))
            {
                Console.WriteLine($"- {books[i]} (Checked In)");
            }
            else if (checkedOutBooks[i])
            {
                Console.WriteLine($"- Book {i + 1} (Checked Out)");
            }
        }
    }

// Call this method after any operation that modifies the library's books or borrowing status
}