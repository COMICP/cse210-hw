using System;

class Program
{
    static void Main(string[] args)
    {

        int tot = 0;
        float ave = 0;
        int max = 0;
        int min = 0;

        List<int> imputs = new List<int>();
        int input = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (input != 0){
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0){
                foreach (int num in imputs){

                    tot = tot + num;

                    if (max < num){
                        max = num;
                    }
                    if (min > num){
                        min = num;
                    }
                }

                ave = tot / imputs.Count;
                Console.WriteLine($"The sum is: {tot} ");
                Console.WriteLine($"the average is: {ave}");
                Console.WriteLine($"The largest number is: {max}");
            }
            else if (input != 0){
                imputs.Add(input);
            }

        }    
        
    }
}