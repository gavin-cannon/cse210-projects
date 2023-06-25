public abstract class Goal{
    protected string _name;
    protected int _points;
    protected string _goalDescription;

    

    public int GetPoints(){
        return _points;
    }
    
    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _goalDescription;
    }

    public virtual int RecordEvent(){
        return _points;
    }
    
    }