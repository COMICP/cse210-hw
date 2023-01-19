using System;
using System.IO; 

class Program
{
    static void Main(string[] args){
        bool qui = false;
        List<string> Entrys = new List<string>();
        int choice;
        string file = "jor.txt";


        while (qui == false){


            choice = takein();
            

            if (choice == 1){
                string responce = wri();
                Console.WriteLine(responce);

                Entrys.Add(responce);

            }


            else if (choice == 2){
                foreach (string choi in Entrys){
                    Console.WriteLine(choi);
                }

            }


            else if (choice == 3){
                Console.WriteLine("What is the file");
                string userfile = Console.ReadLine();
                file = userfile;

                string[] lines = System.IO.File.ReadAllLines(file);
                foreach(string Line in lines){
                    Entrys.Insert(0, Line);
                }

            }


            else if (choice == 4){
                Console.WriteLine("What is the file");
                string userfile = Console.ReadLine();
                file = userfile;
                Console.WriteLine("Saving...");
                

                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    foreach (string choi in Entrys){
                        outputFile.WriteLine(choi);
                    
                    }
                }
                Console.WriteLine("saved");
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

    static string wri(){
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


        return $"Date: {Dat} Prompt: '{prom}' Responce: '{rez}'";
    }

}


