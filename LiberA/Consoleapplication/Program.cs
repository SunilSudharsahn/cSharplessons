using LiberA;
using System.Collections.Concurrent;
using Xceed.Wpf.Toolkit;

Book book = new Book();
book.Title = "kaithi";
book.Author = "Lokesh kanagaraj";
book.Genre = "Action";
book.BookPrice = 1000;
book.DateofPublish = new DateTime(2022,01,01);
book.BookMarkPage(250);
Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int AddResult = calculator.Add(55,60);
Console.WriteLine(AddResult);
int multiplyResult = calculator.Multipy(100, 20);
Console.WriteLine(multiplyResult);
