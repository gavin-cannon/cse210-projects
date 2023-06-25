using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Develop05 World!");
        MainMenu theMainMenu = new MainMenu();
        GoalMenu theGoalMenu = new GoalMenu();
        GoalData DataMothership = new GoalData();
        
        while(true){
            string menuString = theMainMenu.displayMenu();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();
        if (userInput == "1"){
            Console.WriteLine(theGoalMenu.displayMenu());
            theGoalMenu.setAnswer(Console.ReadLine());
            if (theGoalMenu.getAnswer() == "1"){
                Console.WriteLine("What is the name of your goal? ");
                string simpleName = Console.ReadLine();
                Console.WriteLine("Give a brief explanation of your goal. ");
                string simpleBrief = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth? ");
                int simplePointage = int.Parse(Console.ReadLine());
                DataMothership.AddGoal(new SimpleGoal(simpleName, simpleBrief, simplePointage));
            }
            else if (theGoalMenu.getAnswer() == "2"){
                Console.WriteLine("What is the name of your goal? ");
                string eternalName = Console.ReadLine();
                Console.WriteLine("Give a brief explanation of your goal. ");
                string eternalBrief = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth? ");
                int eternalPointage = int.Parse(Console.ReadLine());
                DataMothership.AddGoal(new EternalGoal(eternalName, eternalBrief, eternalPointage));
            }
            else if (theGoalMenu.getAnswer() == "3"){
                Console.WriteLine("What is the name of your goal? ");
                string checkName = Console.ReadLine();
                Console.WriteLine("Give a brief explanation of your goal. ");
                string checkBrief = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth? ");
                int checkPointage = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times must this goal be completed for a bonus? ");
                int checkBonusRequirement = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points are to be awarded for reaching the bonus goal? ");
                int checkBonusPoints = int.Parse(Console.ReadLine());
                DataMothership.AddGoal(new ChecklistGoal(checkName, checkBrief, checkPointage, checkBonusPoints, checkBonusRequirement));
            }

        }
        else if (userInput == "2"){
            Console.WriteLine();
            Console.WriteLine($"Current Score: {DataMothership.GetScore()}");
            int goalNumber = 1;
            foreach (Goal goal in DataMothership.ShowGoals()){
                if (goal is CompletableGoal){
                    if (goal is ChecklistGoal){
                        ChecklistGoal checkGoal1 = (ChecklistGoal)goal;
                        if (checkGoal1.GetCompleted() == true){
                        Console.WriteLine();
                        Console.WriteLine($"{goalNumber}. [X] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {checkGoal1.GetCurrent()}/{checkGoal1.GetRequired()} ");
                    }
                    else{
                        Console.WriteLine();
                        Console.WriteLine($"{goalNumber}. [] {goal.GetName()} {goal.GetDescription()} -- Currently completed: {checkGoal1.GetCurrent()}/{checkGoal1.GetRequired()}");
                    }
                    }
                    if (goal is SimpleGoal){
                    SimpleGoal simpleGoal1 = (SimpleGoal)goal;
                    if (simpleGoal1.GetCompleted() == true){
                        Console.WriteLine();
                        Console.WriteLine($"{goalNumber}. [X] {goal.GetName()} {goal.GetDescription()}");
                    }
                    else{
                        Console.WriteLine();
                        Console.WriteLine($"{goalNumber}. [] {goal.GetName()} {goal.GetDescription()}");
                    }
                    }
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine($"{goalNumber}. [] {goal.GetName()} {goal.GetDescription()}");
                }
                goalNumber += 1;
            }
        }
        else if (userInput == "3"){
            DataMothership.Save(DataMothership.ShowGoals());
        }
        else if (userInput == "4"){
            DataMothership.Load(DataMothership);
        }
        else if (userInput == "5"){
            
        }
        else if (userInput == "6"){
            
            break;
        }
        else{
            Console.WriteLine("Error: Please input a number 1-6.");
        }
        }
    }
}