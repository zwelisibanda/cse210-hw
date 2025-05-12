using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome(){
              Console.WriteLine("Welcome to the program!");
        }
        static String PromptUserName(){
              Console.WriteLine("Please enter your name : ");
              string name = Console.ReadLine();
              return name;
        }
        static int PromptUserNumber(){
              Console.WriteLine("Please enter favorite number : ");
              int favoriteNumber = int.Parse(Console.ReadLine());
              return favoriteNumber;
        }
        static int SquareNumber(int numb){
            int squareRoot = (int)Math.Sqrt(numb);
            return squareRoot;

        }
        static void DisplayResult(String name, int squaredNumber){
            Console.WriteLine($"Hello {name}+ Your favorite number`s square root is  {squaredNumber}");

        }

    }
}