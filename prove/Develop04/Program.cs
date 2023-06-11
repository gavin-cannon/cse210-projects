using System;

class Program
{
    static void Main(string[] args)
    {
        // Set Up Objects
        Menu theMenu = new Menu();
        BreathingActivity Breath1 = new BreathingActivity();
        ListingActivity Listing1 = new ListingActivity();
        ReflectingActivity Reflect1 = new ReflectingActivity();
        
        
       

        // Parse Menu Answer
        while(true){

            string menuString = theMenu.displayMenu();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();

        if (userInput == "1"){
            Console.WriteLine();
            
            Console.WriteLine();
        }
        else if (userInput == "2"){
            string listPrompt = Listing1.ListPrompt();
            Console.Write(listPrompt);
            string userEntry = Console.ReadLine();
            
        }
        else if (userInput == "3"){
            string reflectPrompt = Reflect1.ReflectPrompt();
            
           
            Console.WriteLine();
        
        }
        else if (userInput == "4"){
            Console.Write("Quitting");
            break;
        }
        else{
            Console.WriteLine("Error");
        }
        }
    }
}