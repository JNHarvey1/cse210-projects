using System;

class Activity
{
    private string _name = "";
    private string _desc = "";
    private string _welcomeMessage = "";
    private string _endingMessage = "You have completed this activity";
    private int _duration = 0;

    public Activity()
    {
       // nothing 
    }

    public Activity(string name, 
             string desc, 
             string welcome, 
             string ending, 
             int duration)
    {
        _name = name;
        _desc = desc; 
        _welcomeMessage = welcome; 
        _endingMessage = ending; 
        _duration = duration;
    }

    public void Display()
    {
        System.Console.WriteLine(_name);
        System.Console.WriteLine (_desc);
        System.Console.WriteLine(_welcomeMessage);
        System.Console.WriteLine(_endingMessage);
        System.Console.WriteLine(_duration); 
    }

    public void DisplayDelay(int delay)
    {
        int delta = 500;
        double time = delay * 1000;
        while (time > 0)
        {
            Console.Write("|");
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the character    
            Console.Write("-");
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
            Console.Write("\\");
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");
        }
    }


}