using System;

public class breathingActivity{
    private int _maxtime;

    private string _name = "Breathing Activity";



    private Common common = new Common();

    




    public void StartBreathing(){
        common.StartMessage();
        Console.Clear();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
        
        _maxtime = common.GetTime();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_maxtime);

        int time = 0;

        while (startTime <= futureTime){
            startTime = DateTime.Now;
           
            time = time + 1;

            Console.Clear();
            Console.Write("Breath in...");
            common.CountTime(time);

            Console.Clear();
            Console.Write("Breath out...");
            common.CountTime(time);
        }
        
        common.EndMessage(_maxtime, _name);





    }
}