using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade? ");
        float grade = int.Parse(Console.ReadLine());
        string letterGrade;
        letterGrade = "NA";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else if (grade < 60)
        {
            letterGrade = "F";
        }
        
        else{}

        Console.Write(letterGrade);
    }

    
}