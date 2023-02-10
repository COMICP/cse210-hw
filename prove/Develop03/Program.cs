using System;

class Program
{
    static void Main(string[] args)
    {
        string ver = "This is a test verse to make sure all of the things are working in the program. This should be loaded without issue and have words gradually disappear.";
        string refre = "Reference 1:1";

        scripture test = new scripture();
        test.setverse(ver);
        test.setref(refre);

        memory output = new memory();
        output.setOutput(test);
        output.memoryout();
    }
}