using System;
public class Memory{
    private List<string> _verseout = new List<string>();
    private string _refout;

    public void setOutput(Scripture scripture){
        _verseout.Clear();
        string verse = scripture.getverse();
        _refout = scripture.getrefer();
        foreach (string word in verse.Split(" ")){
            _verseout.Add(word);

        }
            
        
    }

    public void blankline(){
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

        Console.Clear();
        string combinedString = string.Join( " ", _verseout);

        Console.WriteLine($"{_refout} {combinedString}");
        
    }


    public string wordsLeft(){
        int counter = 1;

        foreach(string word in _verseout){
            if (word.Contains("_")){
                counter = counter + 1;
            }
        }
        if (counter == _verseout.Count()){
            
            return "done";
        }
        else{
            int Wordsleft = _verseout.Count - counter;
            return $"wordsLeft = {Wordsleft}";
        }

    }

}