public class ItemList{
    private List<Item> _itemList = new List<Item>();
    public void Load(string file){
        
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines){

            string[] parts = line.Split(":");
            Item item = new Item(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            _itemList.Add(item);
        }
    }
    public void AddItem(Item addedItem){
        _itemList.Add(addedItem);
    }
    public List<Item> LowList(int lowNum){
        List<Item> lowList = new List<Item>();

        foreach(Item i in _itemList){
            int iNum = i.GetAmmount();
            if (iNum <= lowNum){
                lowList.Add(i);
            }
        }

        return lowList;
    }
    public void Save(string file){
        
        string filename = file;
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Item i in _itemList){
                outputFile.WriteLine(i.SaveItem());
            }
        }
    }
    public void Show(){
        
        foreach (Item i in _itemList){
            Console.WriteLine(i.ShowItem());
        }
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    }
    public void Use(){
        Console.WriteLine("What item do you want to use?");
        int count = 0;
        foreach(Item i in _itemList){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _itemList[userInput].UseItem();
    }
    public void SetPrices(){
        Console.WriteLine("What item do you want to update price?");
        int count = 0;
        foreach(Item i in _itemList){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _itemList[userInput].SetPrice();
    }
    public void LowStock(int userInput){
        

        foreach (Item i in _itemList){
            int amm = i.GetAmmount();
            
            if (amm <= userInput){
                Console.WriteLine(i.ShowItem(userInput));
            }
            else{
                
            }
        }
    }
    public virtual void NewItem(){
        Console.WriteLine("What is the name of the item?");
        string newItemName = Console.ReadLine();
        Console.WriteLine("What is the price of the item?");
        int newItemPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("How many items are you adding to inventory?");
        int newItemAmmount = int.Parse(Console.ReadLine());

        Item newItemAdd = new Item(newItemName, newItemPrice, newItemAmmount);

        _itemList.Add(newItemAdd);
    }
    public void RemoveItem(){
        Console.WriteLine("What item do you want to remove?");
        
        DisplayChoices();

        int userInput = int.Parse(Console.ReadLine());
        _itemList.RemoveAt(userInput);
    }
    public void AdjustStock(){
        Console.WriteLine("What item do you want to adjust stock?");
        int count = 0;
        foreach(Item i in _itemList){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _itemList[userInput].SetStock();
    }
    public void DisplayChoices(){
        int count = 0;
        foreach(Item i in _itemList){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
    }
    public Item Single(int itemIndex){
        return _itemList[itemIndex];
    }
    
}