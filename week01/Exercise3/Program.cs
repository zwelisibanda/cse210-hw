using System;
using System.Net;

class Program
{
    
    
    static void Main(string[] args)
    {
    string response = "";
    int guess  = -1;
        Console.WriteLine("What is the magic number");
        int magic_number = Int32.Parse(Console.ReadLine());
        
        while (guess != magic_number){
            Console.Write("What is you guess? ");
            guess = Int32.Parse(Console.ReadLine());
            if(magic_number > guess){
                Console.Write("Higher ");
            }else if(magic_number < guess){
                Console.Write("Lower !");

            }else{
                Console.WriteLine("You guessed it!");
            }
        }
       
    }
}