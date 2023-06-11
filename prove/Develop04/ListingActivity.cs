public class ListingActivity : Activity{
    private List<string> _prompts = new List<string>{"Who are people that you appreciate? ", "What are personal strengths of yours? ", "Who are people that you have helped this week? ", "When have you felt the Holy Ghost this month? ", "Who are some of your personal heroes? "};
    private List<string> _userInput;
    private int _sum;


    public ListingActivity(){
        _name = "Listing Activity";
        _description = "This activity is designed to encourage you to reflect on the positive aspects of your life by creating a list of as many things as possible within a specific area. By actively listing and acknowledging the good things in that particular area, you can cultivate a sense of gratitude and appreciation for the positive aspects of your life.";
    }
    public string ListPrompt(){
        Random rnd = new Random();
        int randomNumber = rnd.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
    public void SetSum(int count){
        _sum = count;
    }
    public int GetSum(){
        return _sum;
    }
}