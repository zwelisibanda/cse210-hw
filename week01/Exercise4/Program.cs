using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<Int>();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int numInput = Int32.Parse(Console.ReadLine());
        while(numInput != 0){
            numbers.Append(numInput);
        }
    }
}