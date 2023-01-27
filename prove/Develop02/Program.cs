using System;
using System.IO; 

class Program
{
    static void Main(string[] args){
        bool qui = false;
        Diary Journal = new Diary();
        int choice;
        string file ;


        while (qui == false){

            choice = takein();
            
            if (choice == 1){
                Jor responce = wri();
                Console.WriteLine(responce);

                Journal.adding(responce);
            }

            else if (choice == 2){
                Journal.openBook();
            }

            else if (choice == 3){
                Console.WriteLine("What is the file name? ");
                file = Console.ReadLine();
                Journal.readFrom(file);
            }

            else if (choice == 4){
                Console.WriteLine("What is the file name? ");
                file = Console.ReadLine();
                Journal.saveTo(file);
            }

            else if (choice == 5){
                qui = true;
                Environment.Exit(choice);           
            }

            else{
                Console.Write("Enter valid input.");
            }
            
        }
        
    }







    static int takein(){
        int cho;
        choice("Please select one of the following choices:");
        choice("1. Write");
        choice("2. Display");
        choice("3. Load");
        choice("4. Save");
        choice("5. Quit");
        cho = int.Parse(Console.ReadLine()); 



        return cho;
    }

    static void choice(string msg){
        Console.WriteLine(msg);

    }

    static string getdate(){
        DateTime now = DateTime.Now;

        return now.ToString("ddd MMM %d, yyyy");

    }

    static Jor wri(){
        string rez;
        string prom;
        Random rnd = new Random();
        List<string> prrompts = new List<string>();

        prrompts.Add("Who was the most interesting person I interacted with today?");
        prrompts.Add("What was the best part of my day?");
        prrompts.Add("How did I see the hand of the Lord in my life today?");
        prrompts.Add("What was the strongest emotion I felt today?");
        prrompts.Add("If I had one thing I could do over today, what would it be?");
        prrompts.Add("What was the most beautifull thing you saw today.");

        prom = prrompts[rnd.Next(5)];



        choice(prom);
        rez = Console.ReadLine();
        string Dat = getdate();

        Jor Entry = new Jor();
        Entry._date = Dat;
        Entry._prompt = prom;
        Entry._responce = rez;


        return Entry;
    }

}


