using System;

public class Jor{
    public string _date;
    public string _prompt;
    public string _responce;

    public void print(){
        Console.WriteLine($"Date: {_date} Prompt: '{_prompt}' Responce: '{_responce}'");
    }
    public string ent(){
        return ($"Date: {_date} Prompt: '{_prompt}' Responce: '{_responce}'");
    }
    public string dat(){
        return _date;
    }
    public string pro(){
        return _prompt;
    }
    public string rez(){
        return _responce;
    }

}