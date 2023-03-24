public class Item : User{
    private string _name;
    private int _price;
    private int _ammount;
    public Item(string name, int price, int ammount){
        _name = name;
        _price = price;
        _ammount = ammount;
    }

    public string GetName(){
        return _name;
    }
    public int GetPrice(){
        return _price;
    }
    
    public string SaveItem(){
        return $"{_name}:{_price}:{_ammount}";
    }
    public void UpdateAmmount(){

    }
    public void UpdatePrice(){
        
    }
    public string ShowItem(){
        if (_ammount < 2){
            return $"";
        }
        else{
            return $""; 
        }
        
    }
    public override void UseItem()
    {
        Console.WriteLine("How many have you used");
        int usage = int.Parse(Console.ReadLine());
        _ammount = _ammount - usage;
    }
    public override void SetPrice()
    {
        Console.WriteLine("what is the new price?");
        int newPrice = int.Parse(Console.ReadLine());
        _price = newPrice;
    }
}