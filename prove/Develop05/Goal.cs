public abstract class Goal{
    private string _name;
    private int _score;
    protected int _points;
    private string _goalName;
    private string _goalDescription;
    public abstract void addPoints();
    public abstract void recordEvent();

    public abstract bool isComplete();
    public int getScore(){
        return _score;
    }
    public void setScore(int score){
        _score = score;
    }
    public Goal(string name, string description, int score){
        _name = name;
        _goalDescription = description;
        _score = score;
    }
    }