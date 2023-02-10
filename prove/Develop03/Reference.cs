using System;

public class Reference{
    private string _reference;

    private string _book;
    private string _chapter;
    private int _startverse;
    private int _endverse;

    public string getreference(){
        return _reference;
    }
    public void setreference(string newverse){
        _reference = newverse;
        string[] broke = newverse.Split(" ");
        string[] verse = broke[1].Split(":");

        _book = broke[0];

        _chapter = verse[0];

        _startverse = int.Parse(verse[1].Split("-")[0]);

        int verlen = (verse[1].Split("-")).Count();        

        if (verlen == 2){
            _endverse = int.Parse(verse[1].Split("-")[1]);
        }

        else{
            _endverse = _startverse;
        }

        
    }
}