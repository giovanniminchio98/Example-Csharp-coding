// See https://aka.ms/new-console-template for more information
using System.Runtime;

Console.WriteLine("Hello, World!");

string s1 = "Hellooooo";    // added to the intern table (is the same for the whole runtime)
string s2 = "Hellooooo";    // alredy there, return ref to table

Console.WriteLine(s1 == s2);                // true
Console.WriteLine(ReferenceEquals(s1, s2)); // true

// automatically are the same, ?
// is string interning

// jit compiler check in intern table if the string is already present or not
// if is there then the it uses the reference instead
// can do this since string are immutable !

// this speed up things

string s3 = "Hello";
s3 += "oooo";
Console.WriteLine(s1 == s3);// true // this actually call the equal method
Console.WriteLine(ReferenceEquals(s1, s3));// false

// we can intern our own string
// if not add it
// else add it
s3 = string.Intern(s3); // VERY DANGEROUS !!
// if done too much we run out of memory

Console.WriteLine(s1 == s3);// true
Console.WriteLine(ReferenceEquals(s1, s3));// true

// this is flyweight pattern !!

// OTHER EXAMPLES

// EVENTSARGS
_ = new EventArgs(); // do not use this one // adding garbage
_ = EventArgs.Empty; // this is better // this is a flyweight

// the below 2 are the same at run time
string empty = "";
_ = string.Empty;// better this one, intention revealing

_ = new int[0];// new empty array on heap // adding garbage
_ = Array.Empty<int>(); // is immutable // better this one, for memory consumption



