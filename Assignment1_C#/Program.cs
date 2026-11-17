// See https://aka.ms/new-console-template for more information

using Assignment1_C_;
using System.Runtime.Intrinsics.X86;


// Q1
Book book = new Book();
book.Title = "book_1";
book.Pages = 222;


Console.WriteLine(book.Title);
Console.WriteLine(book.Pages);


//Q2
Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetType());
Console.WriteLine(book.GetHashCode());


//Q3
// int pages = "464";   It's a compile-time error

// int pages = 464;   


//Q4

try
{
    int x = 10;
    int y = 0;
    int number = x / y;

}
catch(Exception)
{
    Console.WriteLine("Cannot divide by zero");


}
finally
{
    Console.WriteLine("Done");
}


//Q5

int pages = 300;
Double ppages = pages;


//Q6

double price = 49.99;
int newprice = (int)price;


//Q7

string pagesText = "464";
int newpagesText = Convert.ToInt32(pagesText);


//Q8

string yearText = "2023";
int newyearText = int.Parse(yearText);

string badText = "abc";
int newbadText;

   bool result= int.TryParse(badText, out newbadText);
   if(result)
{
    Console.WriteLine(newbadText);
}
else
{
    Console.WriteLine("Invalid number");
}


//Q9

int Pages = 464;
String newPages = Convert.ToString(Pages);
Console.WriteLine(newPages.GetType());

//Q10

int copies = 100;
object Copies = new object();
Copies = copies;
Console.WriteLine(Copies);

int newcopies = (int)Copies;
Console.WriteLine(newcopies);


//Q11

int? year = null;


if(year != null)
{
    Console.WriteLine(year);
}
else
{
    year = 2023;
    Console.WriteLine(year);

}



//Q12

string? reviewer = null;

if(reviewer ==null)
{
    Console.WriteLine(reviewer);
}




