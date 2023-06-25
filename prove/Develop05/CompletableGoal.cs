public abstract class CompletableGoal : Goal{
    protected bool _completed;

    public CompletableGoal(string name, string description, int points){

    }
    public CompletableGoal(){}
    public abstract bool GetCompleted();
    public void SetCompleteTrue(){
        _completed = true;
    }
        
    
}