public class Checklist : Goal{
    private int _bonusScore;
    private int _numberRequired;
    private int _currentNumberComplete;
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

    public Checklist(string name, string description, int baseScore, int bonusScore, int numberRequired) : base(name, description, baseScore){
        _bonusScore = bonusScore;
        _numberRequired = numberRequired;
        _currentNumberComplete = 0;
    }

}