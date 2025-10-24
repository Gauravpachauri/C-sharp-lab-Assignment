using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public virtual void Display()
        {
            Console.WriteLine("BookID: " + BookID +
                              ", Title: " + Title +
                              ", Author: " + Author +
                              ", Available: " + IsAvailable);
        }
    }

    class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public virtual void Display()
        {
            Console.WriteLine("MemberID: " + MemberID +
                              ", Name: " + Name +
                              ", Borrowed Books: " + BorrowedBooks.Count);
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book b)
        {
            books.Add(b);
        }

        public void RegisterMember(Member m)
        {
            members.Add(m);
        }

        public void LendBook(int bookID, int memberID)
        {
            Book book = books.Find(b => b.BookID == bookID && b.IsAvailable);
            Member member = members.Find(m => m.MemberID == memberID);

            if (book != null && member != null)
            {
                book.IsAvailable = false;
                member.BorrowedBooks.Add(book);
                Console.WriteLine(member.Name + " borrowed " + book.Title);
            }
            else
            {
                Console.WriteLine("Book not available or Member not found");
            }
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (Book b in books)
            {
                if (b.IsAvailable)
                    b.Display();
            }
            Console.WriteLine();
        }
    }
    internal class Q7
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book b1 = new Book { BookID = 1, Title = "C# Basics", Author = "John Doe" };
            Book b2 = new Book { BookID = 2, Title = "OOP Concepts", Author = "Jane Smith" };
            library.AddBook(b1);
            library.AddBook(b2);

            Member m1 = new Member { MemberID = 101, Name = "Alice" };
            Member m2 = new Member { MemberID = 102, Name = "Bob" };
            library.RegisterMember(m1);
            library.RegisterMember(m2);

            library.DisplayAvailableBooks();

            library.LendBook(1, 101); // Alice borrows C# Basics
            library.DisplayAvailableBooks(); // C# Basics is no longer available
        }
    }
}
