using System;

public class Common{




    
    protected int GetTime(){
        Console.WriteLine("How long would you like for your session in seconds");
        int sessiontime = int.Parse(Console.ReadLine()); 

        return sessiontime;
        }

    protected string EndMessage(int time, string activity){

        string endMessage = $"You have completed another {time} seconds of {activity}.  ";
        Console.WriteLine(endMessage);
        Spinner();
        return endMessage;
    }

    protected void Spinner(int maxcount = 4){

        int time = 0;
        string spin = @"|/-\";

        while (time <= maxcount){
            time += 1;          
            
            foreach(char icon in spin){
                Thread.Sleep(200);
                Console.Write("\b\b");
                Console.Write($"{icon} ");             
            }
        }

    }


    
    protected void CountTime(int time){
               
        while ( 0 <= time){
        
            Console.Write("\b \b \b");
            Console.Write(time);
            Thread.Sleep(1000);

            time = time - 1;
        }
        Console.WriteLine("");
    }

    protected void StartMessage(){
        Console.Clear();
        Console.Write("Get ready...");
        Spinner(5);
    }
}