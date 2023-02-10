using System;
public class memory{
    private List<string> _verseout = new List<string>();
    private string _refout;

    public void setOutput(scripture scripture){
        string verse = scripture.getverse();
        _refout = scripture.getrefer();
        foreach (string word in verse.Split(" ")){
            _verseout.Add(word);

        }
            
        
    }

    private void blankline(){
        Random rnd = new Random();
        
        int check = 1;


        while(check == 1){
            
            int word = rnd.Next(_verseout.Count());
            string verse = _verseout[word];

            if (verse.Contains("_")){
                Console.Write("nope");
            }
            else {
                List<string> replacement = new List<string>();
                foreach(char letter in verse){
                    
                    replacement.Add("_");
                }
                string rep = string.Join( "", replacement);

                
                _verseout[word] = rep;
                check = check-1;
            }
        }
        


    }
    public void memoryout(){
        string input = "";
        while (input != "quit"){
            Console.Clear();
            string combinedString = string.Join( " ", _verseout);

            Console.WriteLine($"{_refout} {combinedString}");
            Console.WriteLine("Press enter to continue or typoe 'quit' to finish");
            input = Console.ReadLine();
            blankline();
            


        }
    }

}