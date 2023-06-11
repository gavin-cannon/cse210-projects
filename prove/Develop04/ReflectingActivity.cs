public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _followUps = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectingActivity(){
        _name = "Reflecting Activity";
        _description = "This exercise encourages you to think about instances in your life where you demonstrated strength and perseverance. By doing so, you'll gain awareness of your own capabilities and understand how you can apply them to different areas of your life.";
        _duration = 50;

    }
    public string ReflectPrompts(){
        Random rnd = new Random();
        int randomNumber = rnd.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
    public string ReflectFollowUps(){
        Random rnd = new Random();
        int randomNumber = rnd.Next(_prompts.Count);
        return _followUps[randomNumber];
    }
}