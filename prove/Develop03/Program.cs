using System;

class Program
{
    static void Main(string[] args)
    {
        string bible = "bible.txt";



        Book TestBook = new Book();
        TestBook.readFrom(bible);

        Memory output = new Memory();
        output.setOutput(TestBook.GetScripture());
        


        string input = "";
        while (input != "quit"){

            string count = output.wordsLeft();

            output.memoryout();
            Console.WriteLine("To continue press enter, to quit type 'quit', to save type 'save'");
            input = Console.ReadLine();


            
            
                

            if (input == "quit"){
                System.Environment.Exit(0);
            }
            else if (input == "save"){
                TestBook.saveTo(bible);
            }
            else{
                output.blankline();
            }

        

            if (count == "done"){
                output.setOutput(TestBook.GetScripture());
            }


        }
    }
}