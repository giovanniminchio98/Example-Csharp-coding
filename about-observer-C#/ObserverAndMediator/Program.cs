// See https://aka.ms/new-console-template for more information
using ObserverAndMediator;

Console.WriteLine("Hello, World!");

Server s = new Server();
Client c = new Client(s);
Client c1 = new Client(s);// i see the goal message twice since the client print one time each the message

s.TellThemAboutTheGoal("Argentina");

// this pattern is very imp
// and alredy in DOTNET !!

Console.WriteLine("==============================");

