using System;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();
        DataManager artDataManager = new DataManager();
        MediumMenu mediumMenu = new MediumMenu();
        YearMenu yearMenu = new YearMenu();
        artDataManager.LoadArt();
        while (true)
        {
            string menuString = mainMenu.DisplayMenu();
            Console.WriteLine();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                List<Art> artCollection = artDataManager.GetArt();
                Console.WriteLine(yearMenu.DisplayMenu());
                yearMenu.SetAnswer(Console.ReadLine());
                if (yearMenu.GetAnswer() == "1")
                {
                    int number = 1;
                    artCollection.Sort((x, y) => y.GetYear().CompareTo(x.GetYear()));
                    foreach (Art artPiece in artCollection)
                    {
                        Console.WriteLine($"\n{number}. {artPiece.ToString()}");
                        number += 1;
                    }
                }
                else if (yearMenu.GetAnswer() == "2")
                {
                    int number = 1;
                    artCollection.Sort((x, y) => x.GetYear().CompareTo(y.GetYear()));
                    foreach (Art artPiece in artCollection)
                    {
                        Console.WriteLine($"\n{number}. {artPiece.ToString()}");
                        number += 1;
                    }
                }
            }
            else if (userInput == "2")
            {
                List<Art> artCollection = artDataManager.GetArt();
                Console.WriteLine(mediumMenu.DisplayMenu());
                mediumMenu.SetAnswer(Console.ReadLine());
                if (mediumMenu.GetAnswer() == "1")
                {
                    foreach (Art artPiece in artCollection)
                    {
                        if (artPiece is Movie)
                        {
                            Console.WriteLine($"\n{artPiece.ToString()}");
                        }
                    }
                }
                else if (mediumMenu.GetAnswer() == "2")
                {
                    foreach (Art artPiece in artCollection)
                    {
                        if (artPiece is Painting)
                        {
                            Console.WriteLine($"\n{artPiece.ToString()}");
                        }
                    }
                }
                else if (mediumMenu.GetAnswer() == "3")
                {
                    foreach (Art artPiece in artCollection)
                    {
                        if (artPiece is Music)
                        {
                            Console.WriteLine($"\n{artPiece.ToString()}");
                        }
                    }
                }
            }
            else if (userInput == "3")
            {
                Console.Write("Quitting");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                break;
            }
        }
    }
}