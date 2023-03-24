public class ShopList : User{
    protected List<Item> _shoppingList = new List<Item>();
    public int GetTotal(){
        int sum = 0;
        foreach (Item i in _shoppingList){
            sum = sum + i.GetPrice();
        }
        return sum;
    }
    public void ShowList(){

    }
    public void SaveList(){

    }
    public override void AddItem(){
        
    }
    
}