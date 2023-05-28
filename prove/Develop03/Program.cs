using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture memorization program. If you want to hide more words hit the enter key. If you want to quit then input quit. \n \nPress enter to begin. ");
        
        string userInput = Console.ReadLine();
        Scripture theScripture = new Scripture();
        theScripture.LoadScripture();
        int difficulty = 0;
        string displayScripture = "";
       do{
        displayScripture = theScripture.ListToVerse(difficulty);
        difficulty++;
        Console.Write(displayScripture);
        string userInput2 = Console.ReadLine();
        } while (displayScripture != "");
    }

    
}