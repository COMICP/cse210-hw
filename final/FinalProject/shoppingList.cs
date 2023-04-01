public class ShopList : ItemList{
    private List<Item> _itemList = new List<Item>();
    
    public int GetTotalPrice(){
        int totalPrice = 0;
        foreach (Item i in _itemList){
            int singlePrice = i.GetPrice();
            totalPrice += singlePrice;
        }
        return totalPrice;
    }

}

