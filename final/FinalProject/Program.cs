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
                Console.WriteLine(yearMenu.DisplayMenu());
                yearMenu.SetAnswer(Console.ReadLine());
                if (yearMenu.GetAnswer() == "1")
                {
                    int number = 1;
                    artDataManager.SortListForward();


                    for (int i = 0; i < artDataManager.GetArtLength(); i++)
                    {
                        Console.WriteLine($"\n{number}. {artDataManager.GetArtPieceString(i)}");
                        number += 1;
                    }

                }
                else if (yearMenu.GetAnswer() == "2")
                {
                    int number = 1;
                    artDataManager.SortListReverse();
                    for (int i = 0; i < artDataManager.GetArtLength(); i++)
                    {
                        Console.WriteLine($"\n{number}. {artDataManager.GetArtPieceString(i)}");
                        number += 1;
                    }
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine(mediumMenu.DisplayMenu());
                mediumMenu.SetAnswer(Console.ReadLine());
                if (mediumMenu.GetAnswer() == "1")
                {
                    int number = 1;
                    for (int i = 0; i < artDataManager.GetArtLength(); i++)
                    {
                        if (artDataManager.GetMovieString(i) != "None")
                        {
                            Console.WriteLine($"\n{number}. {artDataManager.GetMovieString(i)}");
                            number += 1;
                        }
                    }
                }
                else if (mediumMenu.GetAnswer() == "2")
                {
                    int number = 1;
                    for (int i = 0; i < artDataManager.GetArtLength(); i++)
                    {
                        if (artDataManager.GetPaintingString(i) != "None")
                        {
                            Console.WriteLine($"\n{number}. {artDataManager.GetPaintingString(i)}");
                            number += 1;
                        }
                    }
                }
                else if (mediumMenu.GetAnswer() == "3")
                {
                    int number = 1;
                    for (int i = 0; i < artDataManager.GetArtLength(); i++)
                    {
                        if (artDataManager.GetMusicString(i) != "None")
                        {
                            Console.WriteLine($"\n{number}. {artDataManager.GetMusicString(i)}");
                            number += 1;
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