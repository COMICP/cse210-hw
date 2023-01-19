using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sq = SquareNumber(num);
        DisplayResult(name, sq);

    }
    static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("please enter your name: ");
        string name = Console.ReadLine();
        return name;
            
    }
    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num){
        int sq = num * num;
        return sq;
            
    }
    static void DisplayResult(string name, int num){
        Console.Write($"{name}, the square of your number is {num} ");
            
    }
}