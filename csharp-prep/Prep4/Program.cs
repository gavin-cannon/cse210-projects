using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello Prep4 World!");
        int stopNumber = 1;
        while (stopNumber != 0){
            
            Console.Write("Please enter a number.");
            stopNumber = int.Parse(Console.ReadLine());
            if (stopNumber != 0){
            numbers.Add(stopNumber);
            
            };
        };
    
            int total = 0;
            float average = 0;
            int maxNumber = 0;
            foreach (int number in numbers){
            
            
            total += number;
            average = ((float)total) / numbers.Count;
            if(maxNumber < number){
                maxNumber = number;
            };
            
        };
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max Number: {maxNumber}");
        
    }
}