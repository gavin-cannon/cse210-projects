public class ChecklistGoal : CompletableGoal{
    private int _bonusPoints;
    private int _numberRequired;
    private int _currentNumberComplete;

    public override bool GetCompleted()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        IncreaseCurrent();
        if (_currentNumberComplete >= _numberRequired){
            SetCompleteTrue();
        }
        if (_currentNumberComplete <= _numberRequired){
            if (_currentNumberComplete == _numberRequired){
                return _bonusPoints + _points;
            }
            else{
                return _points;
            }
        }
        else{
            return 0;
        }
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
    public void IncreaseCurrent(){
        _currentNumberComplete += 1;
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