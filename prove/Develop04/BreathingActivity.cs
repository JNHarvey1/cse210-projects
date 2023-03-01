using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", 
                                      "Prepare to take a few deep breathes and clear your mind.",
                                      "welcome",
                                      "You've completed the activity",
                                      duration)
    {

    }

    public BreathingActivity(string name, 
             string desc, 
             string welcome, 
             string ending, 
             int duration) : base(name,
                                  desc,
                                  welcome,
                                  ending,
                                  duration * 2)
    {
    }    

    public void doit()
    {
        DisplayDelay(3);
        System.Console.WriteLine("Prepare to take a few deep breathes and clear your mind.");
        DisplayDelay(3);
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Breathe in");
            DisplayDelay(3);
            System.Console.WriteLine("Breathe out");
            DisplayDelay(3);
        }
        System.Console.WriteLine("You have now completed the breathing exercise.");
    }
}