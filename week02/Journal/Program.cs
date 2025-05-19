using System;

class Program
{
    static void Main(string[] args)
    {
        String welcomeMessage = Console.WriteLine("Welcome to my journal program!");
        String selectText = Console.WriteLine("Please select one of the follwing option");
        String selectText2 = Console.Write("1) Write ");
        String selectText3 = Console.Write("2) Display ");
        String selectText4 = Console.Write("3) Save ");
        String selectText5 = console.Write("4) Load ");
        String selectText6 = Console.Write("5) Exit");


        list<prompt> prompts = new list<prompt>();
        list<response> responses = new list<response>();
         prompts[0] = prompt._meal;
         prompts[1] = prompt._emotions;
         prompts[2] = prompt._scripture;
         prompts[3] = prompt._social;
         prompts[4] = prompt._ministry;
         if(console.readline() == "1"){
            Console.WriteLine("Select prompt to respond to ");
        foreach(prompt in prompts; i = 1 ;){
            
            Console.WriteLine(i")"+prompt)
            i+=1;
        }
         
      }   
      if(console.readLine() == "2"){
        foreach(prompt in prompts){
            Console.WriteLine(prompt);
        }
      }   
        

        }
      public void save (prompt addprompt){
    

      }

    }
}