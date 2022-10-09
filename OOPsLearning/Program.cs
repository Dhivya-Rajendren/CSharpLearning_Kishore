// See https://aka.ms/new-console-template for more information
using OOPsLearning.BookStore;

Console.WriteLine("Hello, World!");
//Abstraction
//Encapsulation
//Inheritance
//Polymorphism

BookStoreMember member = new BookStoreMember();
Console.WriteLine("Member Name");
member.Name = Console.ReadLine();
Console.WriteLine("Member Email");
member.Email    =Console.ReadLine();
Console.WriteLine("BookStore Member Details");
member.PrintDetails();


Author author= new Author();
Console.WriteLine("Author Name");
author.Name = Console.ReadLine();
Console.WriteLine("Author Contact");
author.Contact=long.Parse(Console.ReadLine());
Console.WriteLine("Author details");
author.PrintDetails();