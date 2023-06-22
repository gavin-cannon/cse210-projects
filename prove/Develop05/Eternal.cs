public class Eternal : Goal{
    
    public override void recordEvent()
    {
        
    }
    public override bool isComplete()
    {
        return true;    
    }

    public override void addPoints()
    {
        
    }

    public Eternal(string name, string description, int score) : base(name, description, score){

    }
}