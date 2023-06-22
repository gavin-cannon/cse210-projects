public class GoalData{
    private List<Goal> _goals;
    private int _points;

    public void AddGoal(Goal goal){
        _goals.Add(goal);
    }
    public void AddPoints(int points){
        _points += points;
    }
    public void CompleteGoal(int goalNumber){
        
    }
}