﻿using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

Person baby2 = Person.Procreate(harry, jill);
Person baby3 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(format:"{0}'s first child is named \"{1}\".",
    arg0:harry.Name,
    arg1: harry.Children[0].Name);

WriteLine($"5! is {Person.Factorial(5)}");


static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();


Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value:"Alpha");
lookupIntString.Add(key: 2, value:"Beta");
lookupIntString.Add(key: 3, value:"Gamma");
lookupIntString.Add(key: 4, value:"Delta");

int key = 3;
WriteLine($"Key {key} has value: {lookupIntString[key]}");

WriteLine($"Key {harry} has value: {lookupIntString[4]}");

Person[] person =
{
    new(){Name = "Simon"},
    new(){Name = "Jenny"},
    new(){Name = "Adam"},
    new(){Name = "Richard"},
};

WriteLine("initial list of people");
foreach (Person p in person)
{
    WriteLine($" {p.Name}");
}

WriteLine("Use Person's Icomparable implementation to sort:");
Array.Sort(person);
foreach(Person p in person)
{
    WriteLine($"  {p.Name}");
}

WriteLine("Use PersonComparer's IComparer implementation to sort.:");
Array.Sort(person, new PersonComparer());
foreach (Person p in person)
{
    WriteLine($"  {p.Name}");
}

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;

WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X},{dv2.Y}) = ({dv3.X}, {dv3.Y})");