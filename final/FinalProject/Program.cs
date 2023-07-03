using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        DecadeMenu decadeMenu = new DecadeMenu();
        while (true)
        {
            string menuString = menu1.displayMenu();
            Console.WriteLine();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine(decadeMenu.displayMenu());
                decadeMenu.setAnswer(Console.ReadLine());
                if (decadeMenu.getAnswer() == "1")
                {
                    
                    
                }
                else if (decadeMenu.getAnswer() == "2")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string eternalName = Console.ReadLine();
                    Console.WriteLine("Give a brief explanation of your goal. ");
                    string eternalBrief = Console.ReadLine();
                    Console.WriteLine("How many points is this goal worth? ");
                    int eternalPointage = int.Parse(Console.ReadLine());
                    dataMothership.AddGoal(new EternalGoal(eternalName, eternalBrief, eternalPointage));
                }
                else if (mainMenu.getAnswer() == "3")
                {
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
                    dataMothership.AddGoal(new ChecklistGoal(checkName, checkBrief, checkPointage, checkBonusPoints, checkBonusRequirement));
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine();
                Console.WriteLine($"Current Score: {dataMothership.GetScore()}");
                int goalNumber = 1;
                foreach (Goal goal in dataMothership.ShowGoals())
                {
                    if (goal is CompletableGoal)
                    {
                        if (goal is ChecklistGoal)
                        {
                            ChecklistGoal checkGoal1 = (ChecklistGoal)goal;
                            if (checkGoal1.GetCompleted() == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{goalNumber}. [X] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {checkGoal1.GetCurrent()}/{checkGoal1.GetRequired()} ");
                                goalNumber += 1;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{goalNumber}. [] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {checkGoal1.GetCurrent()}/{checkGoal1.GetRequired()}");
                                goalNumber += 1;
                            }
                        }
                        if (goal is SimpleGoal)
                        {
                            SimpleGoal simpleGoal1 = (SimpleGoal)goal;
                            if (simpleGoal1.GetCompleted() == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{goalNumber}. [X] {goal.GetName()} ({goal.GetDescription()})");
                                goalNumber += 1;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{goalNumber}. [] {goal.GetName()} ({goal.GetDescription()})");
                                goalNumber += 1;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{goalNumber}. [] {goal.GetName()} ({goal.GetDescription()})");
                        goalNumber += 1;
                    }

                }
            }
            else if (userInput == "3")
            {
                dataMothership.Save(dataMothership.ShowGoals());
            }
            else if (userInput == "4")
            {
                dataMothership.Load(dataMothership);
            }
            else if (userInput == "5")
            {
                Console.WriteLine(theRecordMenu.displayMenu());
                int goalNumber = 1;
                foreach (Goal goal in dataMothership.ShowGoals())
                {
                    Console.WriteLine($"{goalNumber}. {goal.GetName()}");
                    goalNumber += 1;
                }
                Console.WriteLine("Which goal did you accomplish?");
                theRecordMenu.setAnswer(Console.ReadLine());
                List<Goal> dataList = dataMothership.ShowGoals();
                Goal index = dataList[int.Parse(theRecordMenu.getAnswer()) - 1];
                if (index is ChecklistGoal)
                {
                    Console.WriteLine("How many times did you complete this goal?");
                    int numberOfCompletion = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numberOfCompletion; i++)
                    {
                        int pointsToAdd = index.RecordEvent();
                        dataMothership.IncreaseScore(pointsToAdd);
                    }
                }
                else
                {
                    if (index is SimpleGoal)
                    {
                        SimpleGoal simpleGoal1 = (SimpleGoal)index;
                        if (simpleGoal1.GetCompleted() == false)
                        {
                            dataMothership.IncreaseScore(simpleGoal1.RecordEvent());
                        }
                        else
                        {
                            Console.WriteLine("This goal is already completed.");
                        }
                    }
                    else
                    {
                        int pointsToAdd = index.RecordEvent();
                        dataMothership.IncreaseScore(pointsToAdd);
                    }
                }

            }
            else if (userInput == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Error: Please input a number 1-6.");
            }
        }

    }
}