public class Menu{
    private string _MenuPrompt = $"Welcome to the minfulness app. Please enter a number to choose the related activity: 1. Breathing Activity 2. Listing Activity 3. Reflecting Activity 4. Muscle Relaxation Activity 5. Quit ";
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