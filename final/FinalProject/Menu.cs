public abstract class Menu{
    private string _MenuPrompt = "Welcome to the Movie Program. Please choose an option: 1. List by specific Decade 2. List all by genre 3. List all by rating ";
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