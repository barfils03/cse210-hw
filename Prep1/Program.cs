using System;
//This is W01 - Monica Solis - Bond, James Bond."
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string varName=Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string varLastname=Console.ReadLine();
        Console.WriteLine($"Your name is {varLastname}, {varName} {varLastname}!");
    }
}