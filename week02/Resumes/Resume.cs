public class Resume
{
    public string _personName = "Ogbomo Osarumwense";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.Write("Jobs:");
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
        
    }

}