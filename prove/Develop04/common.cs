using System;

public class Common{




    
    public int getTime(){
        Console.WriteLine("How long would you like for your session in seconds");
        int sessiontime = int.Parse(Console.ReadLine()); 

        return sessiontime;

    }

    public string endMessage(int time, string activity){


        string endMessage = $"You have completed another {time} seconds of {activity}.  ";

        Console.WriteLine(endMessage);

        spinner();

        return endMessage;
    }

    public void spinner(){

        int time = 0;
        string spin = @"|/-\";

        while (time <= 4){
            time += 1;
            
            
            foreach(char icon in spin){
                Thread.Sleep(200);

                Console.Write("\b \b \b");

                Console.Write(icon);
            }
        }

    }
}