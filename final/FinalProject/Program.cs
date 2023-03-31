using System;

class Program
{
    static void Main(string[] args)
    {
        User currentUser = new User();
        int userChoice = 99;
        while(userChoice != 0){
            Console.Clear();
            BuildHome();
            userChoice = int.Parse(Console.ReadLine());


            if (userChoice == 1){ //show stock
                currentUser.ShowStock();
            }
            else if (userChoice == 2){//add item
                currentUser.AddItem();
            }
            else if (userChoice == 3){//use item
                currentUser.UseItems();
            }
            else if (userChoice ==4 ){//price
                currentUser.SetPrices();
            }
            else if (userChoice == 5){//low stock
                currentUser.LowStock();
            }
            else if (userChoice == 6){//shopping list
                currentUser.MakeList();
            }
            else if (userChoice == 7){//load
                currentUser.load();
            }
            else if (userChoice == 8){//save
                currentUser.Save();
            }
            else if (userChoice == 0){//quit
                
                System.Environment.Exit(0);
            }
            else{
                Console.Write("Please enter valid input");
            }
        }
    }
    public static void BuildHome(){
        Console.WriteLine("Welcome! Please make a selection of what you would like to do.");
        Console.WriteLine("[1] Show my stock");
        Console.WriteLine("[2] Edit stock");
        Console.WriteLine("[3] Use item");
        Console.WriteLine("[4] Edit price of item");
        Console.WriteLine("[5] Show low stock");
        Console.WriteLine("[6] Manage shopping list");
        Console.WriteLine("[7] Load inventory");
        Console.WriteLine("[8] Save inventory");
        Console.WriteLine("[0] Quit");
    }
} 
