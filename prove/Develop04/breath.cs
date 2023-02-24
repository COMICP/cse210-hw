using System;

public class breathingActivity : Common{
    private int _maxtime;

    private string _name = "Breathing Activity";
    public void StartBreathing(){
        StartMessage();
        Console.Clear();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
        
        _maxtime = GetTime();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_maxtime);

        int time = 0;

        while (startTime <= futureTime){
            startTime = DateTime.Now;
           
            time = time + 1;

            Console.Clear();
            Console.Write("Breath in...");
            CountTime(time);

            Console.Clear();
            Console.Write("Breath out...");
            CountTime(time);
        }
        
        EndMessage(_maxtime, _name);
    }
}