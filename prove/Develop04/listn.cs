using System;

public class List{
    private Common common = new Common();

    private List<string> _prompts = new List<string>();



    private int _maxtime;

    private string _name = "Listning Activity";

    private void Initialize(){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void StartListing(){
        Initialize();
        common.StartMessage();
        Console.Clear();
        _maxtime = common.GetTime();

        Random rando = new Random();
        int prompt = rando.Next(_prompts.Count());

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(_prompts[prompt]);
        Console.WriteLine("You may begin in: ");
        common.CountTime(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_maxtime);

        int count = 0;
        while (startTime <= futureTime){
            Console.ReadLine();
            count +=1;
            startTime = DateTime.Now;
        }

        Console.Write($"You were able to get {count} responses!");
        common.EndMessage(_maxtime, _name);
    }

}