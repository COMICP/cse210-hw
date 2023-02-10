using System;
public class scripture{
    private string _verse;
    private reference _ref = new reference();
    public string getverse(){
        return _verse;
    }
    public void setverse(string newverse){
        _verse = newverse;
    }

    public reference getref(){
        return _ref;
    }
    public string getrefer(){
        return _ref.getreference();
    }
    public void setref(string newreference){
        _ref.setreference(newreference);
    }


    public string getscripture(){
        string refout = _ref.getreference();

        return $"{refout}: {_verse}";
    }

}