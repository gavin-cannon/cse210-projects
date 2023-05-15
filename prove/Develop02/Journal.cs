public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    


    // _saveToFile;
    // _loadFromFile;

    public void Display(){
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine($"{entry._EntryDate}, {entry._EntryPrompt}, {entry._EntryInput}");
        }
    }
    public void AddEntry(Entry entry){
        _entryList.Add(entry);
    }
}