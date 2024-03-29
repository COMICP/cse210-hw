public class Item : User{
    private string _name = "";
    private int _price = 0;
    private int _ammount = 0;
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

    public string ShowItem(int lowAmmount = 0){
        if (_ammount < lowAmmount){
            return $"Name: {_name} | Price: {_price} | *LOW STOCK*";
        }
        else{
            return $"Name: {_name} | Price: {_price}"; 
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
    public void SetStock(){
        Console.WriteLine($"Currently {_ammount} {_name} in stock.");
        Console.WriteLine("What is the new ammount in stock?");
        int newAmmount = int.Parse(Console.ReadLine());
        _ammount = newAmmount;
    }
}