using System;

public class breathingActivity{
    private int _maxtime;

    private string _name = "Breathing Activity";



    private Common common = new Common();

    



    private void countTime(int time){
        
        
        while ( 0 <= time){
        
            Console.Write("\b \b \b");

            Console.Write(time);

            Thread.Sleep(1000);

            time = time - 1;

        }
        

    }

    public void startBreathing(){

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();

        _maxtime = common.getTime();

        int time = 0;

        while (time <= _maxtime){
           
            time = time + 1;

            Console.Clear();
            Console.Write("Breath in...");
            countTime(time);

            Console.Clear();
            Console.Write("Breath out...");
            countTime(time);
        }
        
        common.endMessage(_maxtime, _name);





    }
}