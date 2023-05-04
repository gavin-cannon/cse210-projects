using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);

        static void DisplayWelcome(){
            Console.WriteLine("Welcome to Prep5 assignment.");
        };
        static string PromptUserName(){
            Console.Write("What is your name? ");
            string name;
            name = Console.ReadLine();
            return name;
        };
        static int PromptUserNumber(){
            Console.Write("What is your number? ");
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        };
        static int SquareNumber(int number){
            int square;
            square = number * number;
            return square;
        };
        static void DisplayResult(string name, int square){
            Console.WriteLine($"{name}, the square root of your number is {square}.");
        };

    }
}