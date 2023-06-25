public abstract class Menu{
    private string _MenuPrompt;
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
    public Menu(string desc){
        _MenuPrompt = desc;
    }
}   