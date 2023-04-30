using System;
using System.Collections.Generic;
namespace CSharpDictionaryJourney.DictionaryCustomKeyTypes
{
   

    public class CustomKeyTypes
    {
        // This method demonstrates how to create dictionaries with custom key types and use them to access elements.
        public static void CreateDictionariesWithCustomKeyTypes()
        {
            // Create a dictionary with a custom key type of Book.
            var bookDict = new Dictionary<Book, string>();

            // Add elements to the dictionary.
            bookDict.Add(new Book("978-1491946008"), "Learning Python");
            bookDict.Add(new Book("978-1491927086"), "Python for Data Analysis");
            bookDict.Add(new Book("978-0735619678"), "C# Programming Language");

            // Access an element in the dictionary.
            string bookTitle = bookDict[new Book("978-1491946008")];
            Console.WriteLine($"The title of the book with ISBN '978-1491946008' is '{bookTitle}'.");
            Console.WriteLine();

            // Create a dictionary with a custom key type of Student.
            var studentDict = new Dictionary<Student, string>(new StudentEqualityComparer());

            // Add elements to the dictionary.
            studentDict.Add(new Student("Massimo", "Mancini"), "Computer Science");
            studentDict.Add(new Student("Pieter", "Van der Westhuizen"), "Information Technology");
            studentDict.Add(new Student("Kyle", "Simpson"), "Software Engineering");
            studentDict.Add(new Student("Francois", "Chollet"), "Artificial Intelligence");

            // Access an element in the dictionary.
            string major = studentDict[new Student("Massimo", "Mancini")];
            Console.WriteLine($"Massimo Mancini's major is {major}.");
            Console.WriteLine();
        }
    }

    // Define a custom key type of Book.
    public class Book : IEquatable<Book>
    {
        public string ISBN { get; set; }

        public Book(string isbn)
        {
            ISBN = isbn;
        }

        public bool Equals(Book other)
        {
            if (other is null)
                return false;

            return ISBN == other.ISBN;
        }

        public override bool Equals(object obj) => Equals(obj as Book);

        public override int GetHashCode() => (ISBN ?? "").GetHashCode();
    }

    // Define a custom key type of Student.
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    // Define an equality comparer for the Student class.
    public class StudentEqualityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x is null || y is null)
                return false;

            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode(Student obj)
        {
            if (obj is null)
                return 0;

            return (obj.FirstName ?? "").GetHashCode() ^ (obj.LastName ?? "").GetHashCode();
        }
    }

}

