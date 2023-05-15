public class SaveLoad{
    string filename = "journal.txt";
public void Save(Journal journal){
    
using (StreamWriter outputFile = new StreamWriter(filename))
{
    foreach (Entry entry in journal._entryList)
    {
        outputFile.WriteLine($"{entry._EntryDate},{entry._EntryInput},{entry._EntryPrompt}");
    }
}
    }


public void Load(Journal journal){
string[] lines = System.IO.File.ReadAllLines(this.filename);

foreach (string line in lines)
{
    string[] entryData = line.Split(",");

    string date = entryData[0];
    string input = entryData[1];
    string prompt = entryData[2];
    Entry entryToLoad = new Entry(prompt, input, date);
    journal._entryList.Add(entryToLoad);
}
    }
   
}