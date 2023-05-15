public class Entry{
    public string _EntryPrompt;
    public string _EntryInput;
    public string _EntryDate;

    public Entry(string entryPrompt, string entryInput){
        this._EntryPrompt = entryPrompt;
        this._EntryInput = entryInput;
        DateTime now = DateTime.Now;
        this._EntryDate = now.ToShortDateString();
    }
    public Entry(string entryPrompt, string entryInput, string date){
        this._EntryPrompt = entryPrompt;
        this._EntryInput = entryInput;
        DateTime now = DateTime.Now;
        this._EntryDate = date;

    }
}