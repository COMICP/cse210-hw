public class ShopList : User{
    private List<Item> _shoppingList = new List<Item>();
    private string _shopFile;
    public ShopList(string shopFile = "Shopping-list"){
        _shopFile = shopFile;
    }
    public void AddListItem(Item item)
    {
        _shoppingList.Add(item);
    }
    public int GetTotal(){
        int total = 0;
        foreach(Item i in _shoppingList){
            total += i.GetPrice();
        }
        return total;
    }
    public void ShowList(){
        foreach (Item i in _shoppingList){
            i.ShowItem();
        }
    }
    public void SaveList(){
        Console.WriteLine("What file do you want to save the shopping list to?");
        _shopFile = Console.ReadLine();

    }
    
}

