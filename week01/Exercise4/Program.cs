using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int numInput = -1;
        while(numInput != 0){
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            numInput = Int32.Parse(Console.ReadLine());
             if(numInput != 0){
                numbers.Add(numInput);
             }
        }
         int sum  = 0;
         foreach (int num in numbers){
            sum += num;

         }
         Console.WriteLine("The sum is :"+sum);
         float av = ((float)sum / numbers.Count);
         Console.WriteLine("The average is : "+av);
         int start = 0;
         int max = numbers[start];
        
        foreach(int num in numbers){
            if (num > max){
                max = num;
            }
        }
        Console.WriteLine("The max is : "+max);
    }

}