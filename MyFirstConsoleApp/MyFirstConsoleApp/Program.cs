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
        
        while (true)
        {
            Console.Write("\nEnter a book title to add (or type 'exit' to stop): ");
            string bookTitle = Console.ReadLine();

            if (bookTitle.ToLower() == "exit")
                break;

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
                break;
            }
        }

        // Display stored books
        Console.WriteLine("\nLibrary Collection:");
        if (!string.IsNullOrEmpty(book1)) Console.WriteLine($"1. {book1}");
        if (!string.IsNullOrEmpty(book2)) Console.WriteLine($"2. {book2}");
        if (!string.IsNullOrEmpty(book3)) Console.WriteLine($"3. {book3}");
        if (!string.IsNullOrEmpty(book4)) Console.WriteLine($"4. {book4}");
        if (!string.IsNullOrEmpty(book5)) Console.WriteLine($"5. {book5}");
    }
}