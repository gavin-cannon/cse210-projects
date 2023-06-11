public class ListingActivity : Activity{
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> _userInput;
    private int sum;


    public ListingActivity(){
        _name = "Listing";
        _description = "A mindfulness activity that asks you to list things that related to a given topic within the time limit.";
        _duration = 50;
    }
    public string ListPrompt(){
        Random rnd = new Random();
        int randomNumber = rnd.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}