public class Load{
    public void GetScripture(){
        string[] fullScriptures = System.IO.File.ReadAllLines("scriptures.txt");
        Scripture scripture1 = new Scripture();
        Word word1 = new Word("Instantiate");
        

        // Book, Chapter and verse
        string[] book = fullScriptures[0].Split(" ");
        string bookName = book[0];
        int chapterNumber = Int32.Parse(book[1]);
        int verseNumber = Int32.Parse(book[2]);
        new Reference(bookName, chapterNumber, verseNumber);

        // Verse Text
        string[] verseText = fullScriptures[1].Split(" ");
        foreach (string word in verseText){
            new Word(word);
            
        }
        new Scripture();
    
    }
}