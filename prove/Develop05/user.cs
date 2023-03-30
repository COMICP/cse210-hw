public class User{
    protected int _userPoints = 0;
    protected List<Goal> _goals = new List<Goal>();
    public int GetUserPoints(){
        return _userPoints;
    }
    public void load(){
        Console.WriteLine("What is the filename that you want to load from?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        int countLines = 0;
        foreach (string line in lines)
        {
            if (countLines == 0){
                _userPoints = int.Parse(line);
                countLines = countLines + 1;
            }
            else{

                string[] parts = line.Split(":");

                string firstName = parts[0];
                string lastName = parts[1];

                if (int.Parse(parts[5]) == 3){
                    CheckGoal checkNew = new CheckGoal(parts[0], parts[1], int.Parse(parts[2]),int.Parse(parts[7]), int.Parse(parts[3]), 3,int.Parse(parts[6]));
                    _goals.Add(checkNew);
                }

                else if (int.Parse(parts[5]) == 2){
                    EternalGoal eternalNew = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                    _goals.Add(eternalNew);
                }

                else if (int.Parse(parts[5]) == 1){
                    SimpleGoal simpleNew = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), 1, 1,int.Parse(parts[6]));
                    _goals.Add(simpleNew);
                }
            }
        }
    }

    public void SaveGoals(){
        Console.WriteLine("What is the filename that you want to save to?");
        string filename;
        filename = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_userPoints);
            foreach (Goal g in _goals){
                outputFile.WriteLine(g.SaveGoal());
            }
        }
    }
    public void AddPoints(int goalPoints){
        _userPoints = _userPoints + goalPoints;
    }
    public void SetGoal(Goal settingGoal){
        _goals.Add(settingGoal);
    }
    public void ShowGoals(){
        foreach (Goal g in _goals){
            
            g.ShowGoal();
            
        }
    }
    public void DoGoals(){
        int count = 0;
        foreach(Goal g in _goals){
            int tod = g.GetLenght();
            int don = g.NumDone();

            if (tod > don){
                Console.Write($"{count}.   ");
                g.SGShort();
            }

            count += 1;
            
        }
        Console.WriteLine("What Goal did you do?");
        int goalChoice = int.Parse(Console.ReadLine());
        AddPoints(_goals[goalChoice].DoGoal());

    }
}