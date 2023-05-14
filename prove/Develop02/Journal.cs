public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    


    // _saveToFile;
    // _loadFromFile;

    public void Display(){
        Console.Write("HELLO");
    }
    public void AddEntry(Entry entry){
        _entryList.Add(entry);
    }
}