public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected string _openingMessage = "Get Ready!";
    protected string _closingMessage = "Nice Work!";


    public Activity(){

    }
    public Activity(int duration = 50){
        _name = "Listing Activity";
        _description = "In this activity you will mindfully list as many things related to a topic you can within the time limit.";
        _duration = duration;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetOpeningMessage(){
        return _openingMessage;
    }
    public string GetClosingMessage(){
        return _closingMessage;
    }
    public void SetDuration(int seconds){
        _duration = seconds;
    }
    public int GetDuration(){
        return _duration;
    }
}