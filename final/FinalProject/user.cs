public class User{
    private string _userInventoryLocation = "inventory.txt";
    
    private ItemList _userInventory = new ItemList();
    private ShopList _shopList = new ShopList();

    public void SaveInven(){
        _userInventory.Save(_userInventoryLocation);
    }
    public void LoadInven(){
        _userInventory.Load(_userInventoryLocation);
    }
    public void ShowStock(){
        _userInventory.Show();
    }
    public void ManageList(){
        Console.WriteLine("Would you like to do.");
        Console.WriteLine("[1] Increase stock");
        Console.WriteLine("[2] Add Item");
        Console.WriteLine("[3] Remove Item");
        Console.WriteLine("[0] Return Home");

        int rez = int.Parse(Console.ReadLine());

        if (rez == 1){
            _userInventory.AdjustStock();
        }
        else if (rez == 2){
            _userInventory.NewItem();
        }
        else if (rez == 3){
            _userInventory.RemoveItem();
        }
        else{
            return;
        }
    }
    public void UseItems(){
        _userInventory.Use();
    }
    public void SetPrices(){
        _userInventory.SetPrices();
    }
    public void LowStock(){
        Console.WriteLine("Enter low stock ammount:");
        int userInput = int.Parse(Console.ReadLine());
        _userInventory.LowStock(userInput);

        Console.WriteLine("");
        Console.WriteLine("Would you like to add these to shopping list? [Y/N]");
        string userResponceStock = Console.ReadLine();

        if (userResponceStock == "Y"){
            List<Item> lowList = _userInventory.LowList(userInput);
            foreach(Item i in lowList){
                _shopList.AddItem(i);
            }
        }
    }
    
    public void MakeList(){
        int listInput = 99;
        while (listInput != 0){
            Console.Clear();
            Console.WriteLine("Select option:");
            Console.WriteLine("[1] Show current shopping list");
            Console.WriteLine("[2] Add item to shopping list");
            Console.WriteLine("[3] Remove item from shopping list");
            Console.WriteLine("[4] Get list total");
            Console.WriteLine("[5] Save shopping list");
            Console.WriteLine("[0] Return to main menue");
            listInput = int.Parse(Console.ReadLine());
            if (listInput == 1){
                _shopList.Show();
            }
            else if (listInput == 2){
                Console.WriteLine("What item do you want to add");
                _userInventory.DisplayChoices();
                int userInput = int.Parse(Console.ReadLine());
                _shopList.AddItem(_userInventory.Single(userInput));
            }
            else if (listInput == 3){
                _shopList.RemoveItem();
            }
            else if (listInput == 4){
                int totalPrice = _shopList.GetTotalPrice();
                Console.WriteLine($"The list total is {totalPrice}");
            }
            else if (listInput == 4){
                Console.WriteLine($"The total is {_shopList.GetTotalPrice()}");
            }
            else if (listInput == 5){
                Console.WriteLine("Where do you want to save the list");
                string FileLocation = Console.ReadLine();
                _shopList.Save(FileLocation);
            }
            else if (listInput == 0){
                return;
            }

            Console.WriteLine("press ENTER to continue");
        }
    }
    
    
    
}
