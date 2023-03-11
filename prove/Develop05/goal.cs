public class Goal : User{
    private string _name;
    private string _description;
    private int _points;
    private int _length;
    private int _numDone;
    private int _type;

    public Goal (string name, string description, int points, int length, int type, int numDone = 0){
        _name = name;
        _description = description;
        _points = points;
        _length = length;
        _type = type;
        _numDone = numDone;
    }

    public string GetName(){
        return _name;
    }
    public string GetDesc(){
        return _description;
    }
    public int GetPoints(){
        return _points;
    }
    public int GetLenght(){
        return _length;
    }
    public int NumDone(){
        return _numDone;
    }
    public void Inc(){
        _numDone = _numDone + 1;
    }
    
    public virtual int DoGoal(){
    
    _numDone = _numDone + 1;
    return _points;
    }


    public virtual void ShowGoal(){ 

            if (_length == _numDone){
                Console.Write("[X]  ");
            }
            else{
                Console.Write("[ ]  ");
            }


            Console.WriteLine($"{_name} '{_description}'");
    }

    public void SGShort(){
        Console.WriteLine(_name);
    }
    public virtual string SaveGoal(){
        return $"{_name}:{_description}:{_points}:{_length}:{_numDone}:{_type}:{_numDone}";
    }
}