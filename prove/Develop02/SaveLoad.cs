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
    string[] parts = line.Split(",");

    string date = parts[0];
    string input = parts[1];
    string prompt = parts[2];
    journal._entryList.Add(new Entry(prompt, input, date));
}
    }
   
}