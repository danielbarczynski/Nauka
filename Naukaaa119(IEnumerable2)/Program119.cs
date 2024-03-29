﻿using System.Collections;

List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6 };
IEnumerator<int> enumer = ints.GetEnumerator();

while (enumer.MoveNext())
{
    Console.Write(enumer.Current + " ");
}

Library library = new Library();
IEnumerable<Book> library2 = new Library();

Console.WriteLine("\nImplicit foreach loop:");
foreach (var item in library)
    Console.WriteLine(item.ToString());

Console.WriteLine("\nExplicit foreach loop from interface:");
foreach (var item in library2)
    Console.WriteLine(item.ToString());

Console.WriteLine("\nFor loop:");
for (int i = 0; i < library.Length; i++)
    Console.WriteLine(library[i]);

class Library : IEnumerable<Book>
{
    public Book this [int index] => books[index];
    public int Length = books.Count();
    static List<Book> books = new List<Book>()
    {
        new Book { Name = "Game of Thrones", Author = "George RR Marin"},
        new Book { Name = "Harry Potter", Author = "JK Rowling"}
    };

    public IEnumerator<Book> GetEnumerator() => books.GetEnumerator(); //* we could just go with this alone, without implementing interface, but we would lose all linq methods
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

class Book
{
    public string? Name { get; set; }
    public string? Author { get; set; }
    public override string ToString() => $"Book: {Name} Author: {Author}";
}