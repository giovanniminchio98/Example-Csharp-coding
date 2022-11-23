//using System.Linq; // default linq

//using MyOwnLink;// my homemade linq

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 1, 2, 3, 4 };

var query = from n in numbers
            where n % 2 == 0 //even
            select n.ToString();

var method = numbers.Where(n => n % 2 == 0)
                              .Select(n => n.ToString());
    
foreach(var s in method /*query*/)
{
    Console.WriteLine(s);
}

//  HOW TO DISABLE TE DEFAULT LINQ USE IN THE PROGRAM ??    
