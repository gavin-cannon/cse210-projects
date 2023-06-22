public class Menu{
    private string _MenuPrompt = $"Welcome to the Goals app. Please enter a number to choose the related activity: 1. Create New Goal 2. List Goals 3. Save Goals 4. Load Goals 5. Record Event 6. Quit ";
    private string _GoalMenu = "";
    private string _MenuAnswer;
    public string displayMenu(){
        return _MenuPrompt;
    }
    public void setAnswer(string userInput){
        _MenuAnswer = userInput;
    }
    public string getAnswer(){
        return _MenuAnswer;
    }
}   