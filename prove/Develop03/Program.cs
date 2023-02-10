using System;

class Program
{
    static void Main(string[] args)
    {
        string ver = "This is a test verse to make sure all of the things are working in the program. This should be loaded without issue and have words gradually disappear.";
        string refre = "Reference 1:1";

        Scripture test = new Scripture();
        test.setverse(ver);
        test.setref(refre);

        Book TestBook = new Book();
        TestBook.SetScripture(test);

        Memory output = new Memory();
        output.setOutput(TestBook.GetScripture());
        


        string input = "";
        while (input != "quit"){

            string count = output.wordsLeft();

            if (count == "done"){
                output.setOutput(TestBook.GetScripture());
            }
            else{
                output.memoryout();
                Console.WriteLine("To continue press enter, to quit type 'quit'");
                input = Console.ReadLine();

                if (input == "quit"){
                    System.Environment.Exit(0);
                }
                else{
                    output.blankline();
                }

            }
            


        }
    }
}