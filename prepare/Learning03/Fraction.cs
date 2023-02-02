using System;

public class fraction{
    private int _top;
    private int _bottom;
    
    public fraction(){
        _top = 1;
        _bottom = 1;

    }
    public fraction(int number){
        _top = number;
        _bottom = 1;
    }
    public fraction(int top, int bottom){
        _top = top;
        _bottom = bottom; 
    }
    public int getTop(){
        return _top;
    }
    public void setTop(int number){
        _top = number;
    }
    public int getBottom(){
        return _bottom;
    }
    public void setBottom(int number){
        _bottom = number;
    }
    public string getFractionString(){
        return $"{_top}/{_bottom}";
    }
    public double getDecimalValue(){
        return (double)_top / (double)_bottom;
    }

}