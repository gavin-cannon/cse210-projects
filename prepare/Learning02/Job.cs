public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayResults()
{
    Console.WriteLine($"{_jobTitle} at {_company} starting in {_startYear} and ending in {_endYear}.");
}
}