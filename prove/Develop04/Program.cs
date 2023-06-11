using System;

class Program
{
    static void Main(string[] args)
    {

        // for (int i = 5; i> 0; i--){
        //     Console.WriteLine(i);
        //     Thread.Sleep(1000);
        // }

        

        // Set Up Objects
        Menu theMenu = new Menu();
        BreathingActivity Breath1 = new BreathingActivity();
        ListingActivity Listing1 = new ListingActivity();
        ReflectingActivity Reflect1 = new ReflectingActivity();
        Animation animation1 = new Animation();
        
       

        // Parse Menu Answer
        while(true){

            string menuString = theMenu.displayMenu();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();

        if (userInput == "1"){
            Console.Write(Breath1.GetName());
            Console.WriteLine("");
            Console.Write(Breath1.GetDescription());
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            int duration = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
        }
        else if (userInput == "2"){
            Console.Write(Listing1.GetName());
            Console.WriteLine("");
            Console.Write(Listing1.GetDescription());
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            int duration = int.Parse(Console.ReadLine());

            string listPrompt = Listing1.ListPrompt();
            Console.Write(listPrompt);
            string userEntry = Console.ReadLine();
            
        }
        else if (userInput == "3"){
            Console.WriteLine("");
            Console.Write(Reflect1.GetName());
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write(Reflect1.GetDescription());
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(Reflect1.GetOpeningMessage());

            DateTime start = DateTime.Now;
            DateTime future = start.AddSeconds(seconds);
            string reflectPrompt = Reflect1.ReflectPrompts();
            Console.WriteLine(reflectPrompt);
            Console.ReadLine();
            
            while (start < future){
            string followUp = Reflect1.ReflectFollowUps();
            Console.WriteLine("");
            Console.WriteLine(followUp);
            Console.ReadLine();

            List<string> spinner = animation1.GetSpinner();
            
            foreach (string s in animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            }

            
            
           
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
