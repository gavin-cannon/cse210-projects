public class GoalData{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _filename = "goals.txt";

    public void AddGoal(Goal goal){
        _goals.Add(goal);
    }
    public void AddPoints(int points){
        _score += points;
    }
    public void CompleteGoal(int goalNumber){
        
    }
    public void IncreaseScore(int points){
        _score += points;
    }
    public List<Goal> ShowGoals(){
        return _goals;
    }
    public int ListLength(){
        return _goals.Count;
    }
    public int GetScore(){
        return _score;
    }

    public void Save(List<Goal> goals){
    
    using (StreamWriter outputFile = new StreamWriter(_filename)){
        outputFile.WriteLine($"{_score}");
        foreach (Goal goal in _goals)
        {
            if (goal is CompletableGoal){
                if (goal is ChecklistGoal){
                    ChecklistGoal checkGoal1 = (ChecklistGoal)goal;
                    outputFile.WriteLine($"ChecklistGoal,{checkGoal1.GetName()},{checkGoal1.GetDescription()},{checkGoal1.GetPoints()},{checkGoal1.GetBonus()},{checkGoal1.GetCompleted()},{checkGoal1.GetCurrent()},{checkGoal1.GetRequired()}");
                }
                if (goal is SimpleGoal){
                SimpleGoal simpleGoal1 = (SimpleGoal)goal;
                    outputFile.WriteLine($"SimpleGoal,{simpleGoal1.GetName()},{simpleGoal1.GetDescription()},{simpleGoal1.GetPoints()},{simpleGoal1.GetCompleted()}");
                }
                }
                else{
                    outputFile.WriteLine($"EternalGoal,{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}");
                }
        }
        }
    }


public void Load(GoalData _goals){
    string[] lines = System.IO.File.ReadAllLines(this._filename);
        int lineNumber = 0;
        foreach (string line in lines)
        {
            if (lineNumber == 0){
                string[] entryData = line.Split(",");
                _score = int.Parse(entryData[0]);
            }
            else{
                string[] entryData = line.Split(",");

                string type = entryData[0];
                string name = entryData[1];
                string description = entryData[2];
                int points = int.Parse(entryData[3]);
                if (type == "ChecklistGoal"){
                    int bonus = int.Parse(entryData[4]);
                    string boolean = entryData[5];
                    int current = int.Parse(entryData[6]);
                    int required = int.Parse(entryData[7]);
                    ChecklistGoal checklistGoalToLoad = new ChecklistGoal(name, description, points, bonus, required, current, boolean);
                    _goals.AddGoal(checklistGoalToLoad);
                }
                else if (type == "SimpleGoal"){

                }
                }
            lineNumber += 1;
        }
    }
}