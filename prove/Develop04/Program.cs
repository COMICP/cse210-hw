using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4"){
            Console.Clear();

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listning activity");
            Console.WriteLine("4. Quit");
            choice = Console.ReadLine();
            


            if (choice == "1"){
                breathingActivity breath = new breathingActivity();
                breath.StartBreathing();
                
            }

            else if (choice == "2"){
                Reflection reflect = new Reflection();

                reflect.StartReflecting();
            }

            else if (choice == "3"){
                List list = new List();
                list.StartListing();
            }

            else if (choice == "4"){
                System.Environment.Exit(0);
            }
            
            else{
                Console.WriteLine("Please enter valid input");
            }

            
        }
        
    }
}