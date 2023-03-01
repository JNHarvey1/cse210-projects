using System;

class ReflectionActivity : Activity
{
    private List<string> promptList = new List<string> {"Think of a time when you stood up for someone else.", 
                                                        "Think of a time when you did something really difficult.",
                                                        "Think of a time when you helped someone in need.",
                                                        "Think of a time when you did something truly selfless."}; 
    Random rand = new Random();
    private int index = rand.Next(promptList.Length);
    private string randPrompt = promptList[index];
    

    public ReflectionActivity(int duration) : base("Reflection Activity", 
                                      "prepare to reflect on your past",
                                      "welcome",
                                      "You've completed the activity.",
                                      duration)
    {

    }

    public ReflectionActivity(string name, 
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
        System.Console.WriteLine("prepare to reflect on your past");
        DisplayDelay(3);
        System.Console.WriteLine($"{randPrompt}");
        DisplayDelay(3);

        System.Console.WriteLine("You've completed the activity.");
    }
}
