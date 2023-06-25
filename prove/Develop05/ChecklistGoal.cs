public class ChecklistGoal : CompletableGoal{
    private int _bonusScore;
    private int _numberRequired;
    private int _currentNumberComplete;
    public override void recordEvent()
    {
        
    }
    public override bool GetCompleted()
    {
        return _completed;
    }

    public override void addPoints()
    {
        
    }

    public int GetRequired(){
        return _numberRequired;
    }

    public int GetCurrent(){
        return _currentNumberComplete;
    }


    public ChecklistGoal(string name, string description, int baseScore, int bonusScore, int numberRequired){
        _name = name;
        _goalDescription = description;
        _points = baseScore;
        _bonusScore = bonusScore;
        _numberRequired = numberRequired;
        _currentNumberComplete = 0;
    }
    public ChecklistGoal(Goal goal){
        _name = goal.GetName();
        _goalDescription = goal.GetDescription();
        _points = goal.GetPoints();
    }

}