public class User{
    protected List<Item> _userInventory = new List<Item>();
    protected ShopList _list = new ShopList();

    public void load(){
        Console.WriteLine("What is the filename that you want to load from?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines){

            string[] parts = line.Split(":");
            Item item = new Item(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            _userInventory.Add(item);
        }
    }

    public void Save(){
        Console.WriteLine("What is the filename that you want to save to?");
        string filename;
        filename = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Item i in _userInventory){
                outputFile.WriteLine(i.SaveItem());
            }
        }
    }

    public virtual void AddItem(){

    }
    public void UpdateItem(){
        
    }
    public void MakeList(){
        
    }
    public void ShowStock(){
        foreach (Item i in _userInventory){
            Console.WriteLine(i.ShowItem());
        }

    }
    public virtual void UseItem(){
        Console.WriteLine("What item do you want to use?");
        int count = 0;
        foreach(Item i in _userInventory){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _userInventory[userInput].UseItem();
    }
    public virtual void SetPrice(){
        Console.WriteLine("What item do you want to update price?");
        int count = 0;
        foreach(Item i in _userInventory){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _userInventory[userInput].UseItem();
    }
    public void LowStock(){

    }
}
