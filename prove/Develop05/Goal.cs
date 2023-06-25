public abstract class Goal{
    protected string _name;
    protected int _points;
    protected string _goalDescription;
    public abstract void addPoints();
    public abstract void recordEvent();

    

    public int GetPoints(){
        return _points;
    }
    
    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _goalDescription;
    }

    public int RecordEvent(){
        return _points;
    }
    
    }