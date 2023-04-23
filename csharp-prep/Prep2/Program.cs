using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        string letter = " ";
        if (percentage >= 90){
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90){
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80){
            letter = "C";
        }
        else if (percentage >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}.");
        if (percentage >= 70){
            Console.WriteLine("You passed!");
        }
        else{
            Console.WriteLine("You failed.");
        }
    }
}