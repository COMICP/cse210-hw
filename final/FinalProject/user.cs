public class User{
    private string _userInventoryLocation = "inventory.txt";
    
    private List<Item> _userInventory = new List<Item>();
    private ShopList _list = new ShopList();

    public void load(){
        
        string filename = _userInventoryLocation;
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines){

            string[] parts = line.Split(":");
            Item item = new Item(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            _userInventory.Add(item);
        }
    }

    public void Save(){
        
        string filename = _userInventoryLocation;
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Item i in _userInventory){
                outputFile.WriteLine(i.SaveItem());
            }
        }
    }

    public void AddItem(){
        Console.WriteLine("Would you like to do.");
        Console.WriteLine("[1] Increase stock");
        Console.WriteLine("[2] Add Item");
        Console.WriteLine("[3] Remove Item");
        Console.WriteLine("[ENTER] Return Home");
        int rez = int.Parse(Console.ReadLine());

        if (rez == 1){
            AdjustStock();
        }
        else if (rez == 2){
            NewItem();
        }
        else if (rez == 3){
            RemoveItem();
        }
        else{
            return;
        }
    }
    public void MakeList(){
        int listInput = 99;
        while (listInput != 0){
            Console.WriteLine("Select option:");
            Console.WriteLine("[1] Show current shopping list");
            Console.WriteLine("[2] Add item to shopping list");
            Console.WriteLine("[3] Remove item from shopping list");
            Console.WriteLine("[4] Get list total");
            Console.WriteLine("[5] Save shopping list");
            Console.WriteLine("[0] Return to main menue");
            
        }
    }
    public void ShowStock(){
        
        foreach (Item i in _userInventory){
            Console.WriteLine(i.ShowItem());
        }
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    }
    public void UseItems(){
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
    public void SetPrices(){
        Console.WriteLine("What item do you want to update price?");
        int count = 0;
        foreach(Item i in _userInventory){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _userInventory[userInput].SetPrice();
    }
    public void LowStock(){
        Console.WriteLine("Enter low stock ammount:");
        int userInput = int.Parse(Console.ReadLine());

        foreach (Item i in _userInventory){
            int amm = i.GetAmmount();
            
            if (amm <= userInput){
                Console.WriteLine(i.ShowItem(userInput));
            }
            else{
                
            }
        }
        

        
        Console.WriteLine("");
        Console.WriteLine("Would you like to add these to shopping list? [Y/N]");
        string userResponceStock = Console.ReadLine();
        if (userResponceStock == "Y"){
            foreach(Item i in _userInventory){
                int ammountLeft = i.GetAmmount();
                if (ammountLeft <= userInput){
                    
                }
            }
        }
    }
    public void NewItem(){
        Console.WriteLine("What is the name of the item?");
        string newItemName = Console.ReadLine();
        Console.WriteLine("What is the price of the item?");
        int newItemPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("How many items are you adding to inventory?");
        int newItemAmmount = int.Parse(Console.ReadLine());

        Item newItemAdd = new Item(newItemName, newItemPrice, newItemAmmount);

        _userInventory.Add(newItemAdd);
    }
    public void RemoveItem(){
        Console.WriteLine("What item do you want to remove?");
        int count = 0;
        foreach(Item i in _userInventory){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _userInventory.RemoveAt(userInput);
    }
    public void AdjustStock(){
        Console.WriteLine("What item do you want to adjust stock?");
        int count = 0;
        foreach(Item i in _userInventory){
            
            Console.Write($"[{count}]");
            Console.WriteLine(i.ShowItem());
            count += 1;
        }
        int userInput = int.Parse(Console.ReadLine());
        
        _userInventory[userInput].SetStock();
    }
}
