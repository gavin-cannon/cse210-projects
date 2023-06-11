public class ReflectingActivity : Activity{
    private List<string> _prompts;

    public ReflectingActivity(){
        _name = "Reflecting Activity";
        _description = "You will write a reflection on a certain topic to practice mindfulness.";
        _duration = 50;

    }
    public string ReflectPrompt(){
        return "Prompt";
    }
}