public class Book{
    private List<Scripture> _book = new List<Scripture>();

    public Scripture GetScripture(){
        Random scriptureIndex = new Random();
        Scripture scripture = new Scripture();

        scripture = _book[scriptureIndex.Next(_book.Count())];

        return scripture;


    }

    public void SetScripture(Scripture adding){
        _book.Add(adding);
    }

    public void readFrom(string file){
        string refer = "err";
        string vers = "err";
        
        
        
        int count = 1;

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string Line in lines){
        
            if (count == 1){
                refer = Line;
                
            }
            else if (count == 2){
                vers = Line;

                count = 0;

                Scripture Entry = new Scripture();
                
                Entry.setref(refer);
                Entry.setverse(vers);

                _book.Add(Entry);

            }
            count = count +1;

        }
    }

    public void saveTo(string file){
        Console.WriteLine("Saving...");
                

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Scripture entry in _book){
                string refer = entry.getrefer();
                outputFile.WriteLine(refer);

                string ver = entry.getverse();
                outputFile.WriteLine(ver);

                
            
            }
        }
        Console.WriteLine("saved");

    }


    

}