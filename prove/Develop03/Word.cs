public class Word{
    private string _word;
    private Boolean _hidden;

    public Word(string word, Boolean hidden = false){
        _word = word;
    }
    public string getWord(){
        return _word;
    }
    public Boolean getHidden(){
        return _hidden;
    }
    public void setHidden(Boolean hidden){
        _hidden = hidden;
    }
    // return word if visible and return _ if it isnt
}