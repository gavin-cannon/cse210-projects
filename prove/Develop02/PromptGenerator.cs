public class PromptGenerator{
    public List<string> _promptList = new List<string>();
    
    public string SelectPrompt(){
        _promptList.Add("What was the best part of your day?");
        _promptList.Add("What was the worst part of your day?");
        _promptList.Add("What's something you learned today?");
        _promptList.Add("How have you seen the hand of God in your life today?");
        _promptList.Add("What do you want to do tomorrow?");
        _promptList.Add("What step did you take toward your goals?");
        Random number = new Random();
        
        return _promptList[number.Next(_promptList.Count())];
    }
}