public abstract class Goal{
    protected string _name;
    protected int _score;
    protected int _points;
    private string _goalName;
    protected string _goalDescription;
    public abstract void addPoints();
    public abstract void recordEvent();

    public int GetScore(){
        return _score;
    }
    public void SetScore(int score){
        _score = score;
    }

    public int GetPoints(){
        return _points;
    }
    
    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _goalDescription;
    }
    
    }