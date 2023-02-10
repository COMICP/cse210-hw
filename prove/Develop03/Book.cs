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

    

    

}