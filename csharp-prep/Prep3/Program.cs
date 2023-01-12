using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        
        int numb = randomGenerator.Next(1,101);
        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        while (numb != guess){
            

            if (numb > guess){
                Console.WriteLine("Higher");
            }

            else if (numb < guess){
                Console.WriteLine("Lower");
            }
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            
        }
        if (guess == numb){
            Console.WriteLine("You did it!");
        }


        
    }
}