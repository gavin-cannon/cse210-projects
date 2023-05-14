using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu
        Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        Menu menu = new Menu();
        PromptGenerator prompt = new PromptGenerator();
        Console.Write(menu.displayMenu());
        menu._MenuAnswer = Console.ReadLine();
        menu._MenuAnswer = menu._MenuAnswer.ToLower();
        while(true){
        if (menu._MenuAnswer == "1"){
            journal.Display();
        }
        else if (menu._MenuAnswer == "2"){
            string currentPrompt = prompt.SelectPrompt();
            Console.Write(currentPrompt);
            string userEntry = Console.ReadLine();
            journal.AddEntry(new Entry(currentPrompt, userEntry));
        }
        else if (menu._MenuAnswer == "3"){
            Console.Write("Saving...");
            SaveLoad saveLoad = new SaveLoad();
            saveLoad.Save(journal);
        
        }
        else if (menu._MenuAnswer == "4"){
            Console.Write("Load");
            SaveLoad saveLoad = new SaveLoad();
            saveLoad.Load(journal);
            
        }
        else if (menu._MenuAnswer == "5"){
            Console.Write("Quiting");
            break;
        }
        else{
            Console.WriteLine("Error");
        }
        }
    }
}