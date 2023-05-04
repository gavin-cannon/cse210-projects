public class Resume{
    public string _member;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume(){
        Console.WriteLine(_member);
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs){
            job.DisplayResults();
        }
    }

}