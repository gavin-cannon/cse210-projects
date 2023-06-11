public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected string _openingMessage;
    protected string _closingMessage;


    public Activity(){

    }
    public Activity(int duration = 50){
        _name = "Listing Activity";
        _description = "In this activity you will mindfully list as many things related to a topic you can within the time limit.";
        _duration = duration;
    }
}