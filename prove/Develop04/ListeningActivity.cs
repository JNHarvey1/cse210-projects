using System;

class ListeningActivity : Activity
{
    public ListeningActivity(int duration) : base("Listen", 
                                      "prepare to listen",
                                      "welcome",
                                      "You've completed the activity.",
                                      duration)
    {

    }

    public ListeningActivity(string name, 
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
        System.Console.WriteLine("prepare to view a propmt and answer with as many things as you can think of.");
        DisplayDelay(3);
        System.Console.WriteLine("Who are people that you have helped this week?");
        String input = Console.ReadLine();
        List<String> userList = new List<String>();
        userList.Add(input);
        String inputNewUser = Console.ReadLine();
        userList.Add(inputNewUser);
        int num = userList.Count();
    }
}