using System;

public class Reflection : Common{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    private int _maxtime;

    private string _name = "Reflection";

    private void Initialize(){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void StartReflecting(){
        Initialize();
        StartMessage();
        Console.Clear();

        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        _maxtime = GetTime();
        

        Console.WriteLine("Consider the following prompt:");

        Random rando = new Random();
        int prompt = rando.Next(_prompts.Count());
        Console.WriteLine(_prompts[prompt]);

        Console.WriteLine("When you have somehting in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience");

        Console.WriteLine("you may begin in: ");
        CountTime(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_maxtime);



        while (startTime <= futureTime){
            startTime = DateTime.Now;
            int quest = rando.Next(_questions.Count());

            Console.WriteLine(_questions[quest]);
            
            Spinner();


        }
        EndMessage(_maxtime, _name);

    }
}