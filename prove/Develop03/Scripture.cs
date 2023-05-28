public class Scripture{
    private List<Word> _scripture = new List<Word>();
    private Reference _reference;

public Scripture(){

    }
    public Scripture(Reference _reference, List<Word> verse){
       
    }
    public string RenderScripture(){
        string scripture;
        scripture = "hello";
        return scripture;
    }
    public void AddToList(Word word){
        _scripture.Add(word);
    }
    public string ListToVerse(int difficulty){
        Random rnd = new Random();
        int num = rnd.Next(_scripture.Count);
        string newString = "";
        int index = 0;
        foreach (Word item in _scripture){
            if(item.getHidden() != true){
newString += item.getWord() + " ";
            }
            else{
                // for(int i = 0; i < item.getWord().Count; i++){
                //     newString += "_";
                // }
            }
            
            if (difficulty != 0 && index == num){
                item.setHidden(true);
            }
            index++;
        }
        return newString;
    }
public string LoadScripture(){
        string[] fullScriptures = System.IO.File.ReadAllLines("scriptures.txt");
        Word word1 = new Word("Instantiate");
        

        // Book, Chapter and verse
        string[] book = fullScriptures[0].Split(" ");
        string bookName = book[0];
        int chapterNumber = Int32.Parse(book[1]);
        int verseNumber = Int32.Parse(book[2]);
        _reference = new Reference(bookName, chapterNumber, verseNumber);

        // Verse Text
        string[] verseText = fullScriptures[1].Split(" ");
        foreach (string word in verseText){
            _scripture.Add(new Word(word));
            
        }
        return "tavares";
    }
    
}