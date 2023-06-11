public class ListingActivity : Activity{
    private List<string> _prompts;
    private List<string> _userInput;
    private int sum;


    public ListingActivity(){
        _name = "Listing";
        _description = "A mindfulness activity that asks you to list things that related to a given topic within the time limit.";
        _duration = 50;
    }
    public string ListPrompt(){
        return "Prompt";
    }
}