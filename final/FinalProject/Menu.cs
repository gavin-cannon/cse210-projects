public abstract class Menu
{
    protected string _menuPrompt;
    private string _menuAnswer;
    public string DisplayMenu()
    {
        return _menuPrompt;
    }
    public void SetAnswer(string userInput)
    {
        _menuAnswer = userInput;
    }
    public string GetAnswer()
    {
        return _menuAnswer;
    }
    public Menu() { }
    public Menu(string menu)
    {
        _menuPrompt = menu;
        _menuAnswer = "";
    }
}