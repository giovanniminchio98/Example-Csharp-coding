// See https://aka.ms/new-console-template for more information
using IteratorExample;
using System.Globalization;
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

List<int> n = new List<int> { 1, 2, 3};
IEnumerable<int> enumerable = n as IEnumerable<int>;

IEnumerator<int> enumerator = enumerable.GetEnumerator();//factory method

// to use it
while(enumerator.MoveNext() == true){
    int num = enumerator.Current;
    Console.WriteLine(num);
}

// or in for=each (syntax sugar, like the one above actually)
foreach(int i in n)
{
    Console.WriteLine(i);
}

// another example
List<string> letters = new List<string> { "A", "B", "C" };
foreach(string letter in letters)
{
    foreach(int i in n)
    {
        Console.WriteLine($"{letter}{i}");
    }
}

// eith enum
IEnumerator<string> letter_enum = letters.GetEnumerator();
IEnumerator<int> num_enum = n.GetEnumerator();

while(letter_enum.MoveNext() == true && num_enum.MoveNext())
{
    Console.WriteLine($"{letter_enum.Current}{num_enum.Current}");
}

foreach(var x in letters.Zip(n))
{
    Console.WriteLine($"{x.First}");
}

// example of custom made iterator / enumerator
/// ... 
MyCollection coll = new();
foreach(var el in coll)
{
    Console.WriteLine(el);
}



