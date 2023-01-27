using System;

public class Diary{
    public List<Jor> _Entries = new List<Jor>();




    public void adding(Jor entry){
        _Entries.Add(entry);
        
    }

    public void openBook(){
        foreach (Jor choi in _Entries){
            choi.print();
        }
    }



    public void readFrom(string file){
        string pr = "err";
        string da = "err";
        string re = "err";
        
        
        int count = 1;

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string Line in lines){
        
            if (count == 1){
                da = Line;
                
            }
            else if (count == 2){
                pr = Line;

            }
            else if (count == 3){
                re = Line;
                count = 0;

                Jor Entry = new Jor();

                Entry._responce = re;                        
                Entry._date = da;
                Entry._prompt = pr;

                _Entries.Add(Entry);

            }
            
            count = count +1;

        }
    }



    public void saveTo(string file){
        Console.WriteLine("Saving...");
                

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Jor choi in _Entries){
                string dat = choi.dat();
                outputFile.WriteLine(dat);

                string pro = choi.pro();
                outputFile.WriteLine(pro);

                string rez = choi.rez();
                outputFile.WriteLine(rez);
            
            }
        }
        Console.WriteLine("saved");

    }

}
