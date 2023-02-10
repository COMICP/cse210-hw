using System;
public class Scripture{
    private string _verse;
    private Reference _ref = new Reference();
    public string getverse(){
        return _verse;
    }
    public void setverse(string newverse){
        _verse = newverse;
    }

    public Reference getref(){
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