using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        
        
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();


        MathAssignment math1 = new MathAssignment("Robert Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        string mathHomework = math1.GetHomeworkList();
        string mathSum = math1.GetSummary();
        Console.WriteLine(mathSum);
        Console.WriteLine(mathHomework);


        WritingAssignment writeAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string titleGet = writeAssignment.GetWritingInformation();
        string writeSummary = writeAssignment.GetSummary();
        Console.WriteLine();
        Console.WriteLine(writeSummary);
        Console.WriteLine(titleGet);
        





    }
}