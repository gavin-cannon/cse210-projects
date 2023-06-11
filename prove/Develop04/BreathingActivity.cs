public class BreathingActivity : Activity{
    private string _breathingInMessage = "Breathe in";
    private string _breathingOutMessage = "Breathe out";

    public BreathingActivity(){
        _name = "Breathing Activity";
        _description = "This activity will help you practice mindfulness through controlled breathing within the time limit.";
        _duration = 50;
        _openingMessage = "Get ready to practice minful breathing";
        _closingMessage = "Nice work!";
    }
    public void Breath(){
        
    }
}