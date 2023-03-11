using System;

class Program
{
    static void Main(string[] args)
    {   
        User mainUser = new User();
        int userchoice = 0;
        while (userchoice != 6){
            Console.Clear();
            BuildInterface(mainUser.GetUserPoints());
            userchoice = GetChoice();
            if (userchoice == 1){
                Console.WriteLine("What type of goal is it?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. List Goal");
                int goaltype = GetChoice();

                if (goaltype == 1){
                    Console.WriteLine("What is the name? ");
                    string simpleName = Console.ReadLine();

                    Console.WriteLine("Describe the goal. ");
                    string simpleDesc = Console.ReadLine();

                    Console.WriteLine("How many points is it worth? ");
                    int simplePoints =int.Parse(Console.ReadLine()) ;

                    SimpleGoal simple = new SimpleGoal(simpleName, simpleDesc, simplePoints);
                    mainUser.SetGoal(simple);

                }
                else if (goaltype == 2){
                    Console.WriteLine("What is the name? ");
                    string simpleName = Console.ReadLine();

                    Console.WriteLine("Describe the goal. ");
                    string simpleDesc = Console.ReadLine();

                    Console.WriteLine("How many points is it worth? ");
                    int simplePoints =int.Parse(Console.ReadLine()) ;

                    EternalGoal eternalGoal = new EternalGoal(simpleName, simpleDesc, simplePoints);
                    mainUser.SetGoal(eternalGoal);
                }
                else if (goaltype == 3){
                    Console.WriteLine("What is the name? ");
                    string listName = Console.ReadLine();

                    Console.WriteLine("Describe the goal. ");
                    string listDesc = Console.ReadLine();

                    Console.WriteLine("How many points is it worth? ");
                    int listPoints =int.Parse(Console.ReadLine()) ;

                    Console.WriteLine("How many times do you want to do this? ");
                    int listLength =int.Parse(Console.ReadLine()) ;

                    Console.WriteLine("What is the bonus for finishing this? ");
                    int listBonus =int.Parse(Console.ReadLine()) ;

                    CheckGoal checkList = new CheckGoal(listName, listDesc, listPoints,listBonus, listLength );
                    mainUser.SetGoal(checkList);
                }

            }
            else if (userchoice == 2){
                mainUser.ShowGoals();
                Console.ReadLine();
            }
            else if (userchoice == 3){
                mainUser.SaveGoals();
            }
            else if (userchoice == 4){
                mainUser.load();
            }
            else if (userchoice == 5){
                mainUser.DoGoals();
            }
            else if (userchoice == 6){
                System.Environment.Exit(0);
            }
            else{
                Console.Write("Please enter valid input");
            }

        }
        
}
    private static void BuildInterface(int points){
        Console.WriteLine($"Points: {points}");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Do a Goal");
        Console.WriteLine("   6. Quit");

    }
    private static int GetChoice(){
        Console.Write("Select a choice from the menu: ");
        int ChoiceMenue = int.Parse(Console.ReadLine()) ;
        return ChoiceMenue;

    }

}