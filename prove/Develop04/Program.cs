using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // I created a new activity based on the relaxation technique of tensing and releasing your muscles.
        // It follows all the same rules as the others. It is a sub class and has private member variables. 
        // That exceeds the requirements.
        

        

        // Set Up Objects
        Menu theMenu = new Menu();
        BreathingActivity Breath1 = new BreathingActivity();
        ListingActivity Listing1 = new ListingActivity();
        ReflectingActivity Reflect1 = new ReflectingActivity();
        Animation Animation1 = new Animation();
        MuscleRelaxationActivity Muscle1 = new MuscleRelaxationActivity();
        
       

        // Parse Menu Answer
        while(true){

            string menuString = theMenu.displayMenu();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();

        if (userInput == "1"){
            Console.Write($"Welcome to the {Breath1.GetName()}");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write(Breath1.GetDescription());
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            Breath1.SetDuration((int.Parse(Console.ReadLine())));
            Console.WriteLine("");
            Console.WriteLine(Breath1.GetOpeningMessage());
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(800);
                Console.Write("\b \b");
            }
            DateTime start = DateTime.Now;
            DateTime future = start.AddSeconds(Breath1.GetDuration());
            DateTime currentTime = DateTime.Now;
            while (currentTime < future){
            Console.WriteLine();
            Console.WriteLine("Breathe in");
            for (int i = 5; i> 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            Console.WriteLine("Breathe out");
            for (int i = 5; i> 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
            }
            Console.WriteLine("");
            Console.WriteLine(Breath1.GetClosingMessage());
            
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
        else if (userInput == "2"){
            int userEntryCount = 0;
            Console.Write($"Welcome to the {Listing1.GetName()}");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write(Listing1.GetDescription());
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            Listing1.SetDuration((int.Parse(Console.ReadLine())));
            
            Console.WriteLine(Listing1.GetOpeningMessage());
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            string listPrompt = Listing1.ListPrompt();
            
            
            Console.WriteLine("Begin");
            DateTime start = DateTime.Now;
            DateTime future = start.AddSeconds(Listing1.GetDuration());
            DateTime currentTime = DateTime.Now;

            while (currentTime < future){
            Console.Write(listPrompt);
            string userEntry = Console.ReadLine();
            userEntryCount += 1;
            currentTime = DateTime.Now;
            Listing1.SetSum(userEntryCount);
            }
            
            Console.WriteLine($"You wrote {Listing1.GetSum()} entries.");
            Console.WriteLine(Listing1.GetClosingMessage());
            
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            
        }
        else if (userInput == "3"){
            Console.WriteLine("");
            Console.Write($"Welcome to the {Reflect1.GetName()}");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write(Reflect1.GetDescription());
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            Reflect1.SetDuration((int.Parse(Console.ReadLine())));
            Console.WriteLine("");
            Console.WriteLine(Reflect1.GetOpeningMessage());
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(600);
                Console.Write("\b \b");
            }
            DateTime start = DateTime.Now;
            DateTime future = start.AddSeconds(Reflect1.GetDuration());
            string reflectPrompt = Reflect1.ReflectPrompts();
            Console.WriteLine(reflectPrompt);
            Console.ReadLine();
            DateTime currentTime = DateTime.Now;
            while (currentTime < future){
            string followUp = Reflect1.ReflectFollowUps();
            Console.WriteLine("");
            Console.WriteLine(followUp);
            Console.ReadLine();

            List<string> spinner = Animation1.GetSpinner();
            
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
            }
            Console.WriteLine("");
            Console.WriteLine(Reflect1.GetClosingMessage());
            
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        else if (userInput == "4"){
            Console.Write($"Welcome to the {Muscle1.GetName()}");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write(Muscle1.GetDescription());
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("How long in seconds do you want to spend on this activity? ");
            Muscle1.SetDuration((int.Parse(Console.ReadLine())));
            Console.WriteLine("");
            Console.WriteLine(Muscle1.GetOpeningMessage());
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(800);
                Console.Write("\b \b");
            }
            DateTime start = DateTime.Now;
            DateTime future = start.AddSeconds(Muscle1.GetDuration());
            DateTime currentTime = DateTime.Now;
            while (currentTime < future){
            Console.WriteLine();
            string muscleGroup = Muscle1.GetMuscleGroup();
            Console.WriteLine($"{Muscle1.GetBuildTension()} {muscleGroup} {Muscle1.GetComfortably()}");
            
            for (int i = 4; i> 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine($"{Muscle1.GetHoldTension()}");
            for (int i = 5; i> 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine($"{Muscle1.GetReleaseTension()}");
            for (int i = 4; i> 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
            }
            Console.WriteLine("");
            Console.WriteLine(Muscle1.GetClosingMessage());
            List<string> spinner = Animation1.GetSpinner();
            
            foreach (string s in Animation1.GetSpinner()){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        else if (userInput == "5"){
            Console.Write("Quitting");
            for (int i = 3; i> 0; i--){
            Console.Write(".");
            Thread.Sleep(1000);
            }
            break;
        }
        else{
            Console.WriteLine("Error");
        }
        }
    }
}
