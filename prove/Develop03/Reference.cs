public class Reference{
    private string _storeBook;
    private int _storeChapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string bookName, int chapterName, int verseNumber){
        _storeBook = bookName;
        _storeChapter = chapterName;
        _startVerse = verseNumber;

    }

    public Reference(string bookName, int chapterName, int verseNumber1, int verseNumber2){
        
    }
}