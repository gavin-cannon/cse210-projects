public class MuscleRelaxationActivity : Activity{
    private List<string> _muscleGroups = new List<string>{"your Hands and Forearms", "your Shoulders and Neck", "your Face", "your Abdomen", "your Legs and Feet"};
    private string _buildTension = "Gradually build tension in";
    private string _comfortably = "as comfortably as you can while keeping the rest of your body loose and relaxed.";
    private string _holdTension = "Hold the tension. Be mindful of the tight sensations that might be present.";
    private string _releaseTension = "Release the tension quickly. Be mindful of the feeling of release and relaxation. Reflect on that feeling for a moment.";

    public MuscleRelaxationActivity(){
        _name = "Muscle Relaxation Activity";
        _description = "The muscle tensing and releasing activity is a relaxation technique that involves intentionally tensing and then releasing different muscle groups in your body. By focusing on the sensations of tension and relaxation, this technique promotes physical and mental relaxation, reduces stress, and enhances overall well-being.";
    }
    public string GetBuildTension(){
        return _buildTension;
    }
    public string GetMuscleGroup(){
        Random rnd = new Random();
        int randomNumber = rnd.Next(_muscleGroups.Count);
        return _muscleGroups[randomNumber];
    }
    public string GetHoldTension(){
        return _holdTension;

    }
    public string GetReleaseTension(){
        return _releaseTension;
    }
    public string GetComfortably(){
        return _comfortably;
    }
}