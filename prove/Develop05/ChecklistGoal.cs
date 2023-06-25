public class ChecklistGoal : CompletableGoal{
    private int _bonusPoints;
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

    public int GetBonus(){
        return _bonusPoints;
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
        _bonusPoints = bonusScore;
        _numberRequired = numberRequired;
        _currentNumberComplete = 0;
    }

    public ChecklistGoal(string name, string description, int baseScore, int bonusScore, int numberRequired, int current, string completed){
        _name = name;
        _goalDescription = description;
        _points = baseScore;
        _bonusPoints = bonusScore;
        _numberRequired = numberRequired;
        _currentNumberComplete = current;
        if (completed == "True"){
            _completed = true;
        }
        else{
            _completed = false;
        }
    }
    public ChecklistGoal(Goal goal){
        _name = goal.GetName();
        _goalDescription = goal.GetDescription();
        _points = goal.GetPoints();
    }

}