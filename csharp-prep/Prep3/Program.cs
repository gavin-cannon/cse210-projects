using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 100);
        // Console.Write("Magic Number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());
        bool loop = false;
        while (loop == false){
            if (guessNumber == magicNumber){
                loop = true;
                Console.WriteLine("Congrats.");
            }
            else{
                Console.WriteLine("Try again.");
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
        };
    }
}