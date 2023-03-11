public class CheckGoal : Goal{
    
    private int _bonus;
    
    public CheckGoal(string name, string description, int points, int bonus, int length, int type = 3, int numDone = 0): base (name, description, points, length, type, numDone){
        
        _bonus = bonus;
    }
    
    public override int DoGoal()
    {
        
        int done = NumDone();
        int len = GetLenght();
        int addPoints = GetPoints();
        Inc();
        

        if (done == len - 1){
            return addPoints + _bonus;
        }
        else{
            return addPoints;
        }
        
    }
    public override void ShowGoal()
    {
        int length = GetLenght();
        int numDone = NumDone();
        string name = GetName();
        string desc = GetDesc();
        if (length == numDone){
                Console.Write("[X]  ");
            }
            else{
                Console.Write("[ ]  ");
            }


            Console.Write($"{name} '{desc}'");
            Console.WriteLine($"  ({numDone} / {length})");
    }
    public override string SaveGoal()
    {
        return $"{base.SaveGoal()}:{_bonus}";
    }
}