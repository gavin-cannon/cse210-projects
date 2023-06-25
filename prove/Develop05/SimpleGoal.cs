public class SimpleGoal : CompletableGoal{
   
    public SimpleGoal(string name, string description, int points){
        _name = name;
        _goalDescription = description;
        _points = points;
    }
    public SimpleGoal(Goal goal){
        _name = goal.GetName();
        _goalDescription = goal.GetDescription();
        _points = goal.GetPoints();
    }
    public override bool GetCompleted()
    {
        return _completed;
    }
    public override int RecordEvent()
    {
        SetCompleteTrue();
        return _points;
    }
}