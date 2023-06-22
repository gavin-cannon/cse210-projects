public class Simple : Goal{
    protected bool _completed = true;
    public Simple(string name, string description, int score) : base(name, description, score){
    }
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
}