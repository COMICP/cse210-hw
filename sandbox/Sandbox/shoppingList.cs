public class ShopList : User{
    private string _shopFile = "";
    private List<Item> _shoppingList = new List<Item>();
    public int GetTotal(){
        int sum = 0;
        foreach (Item i in _shoppingList){
            sum = sum + i.GetPrice();
        }
        return sum;
    }

    
}