using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity b = new BreathingActivity(60);
        ReflectionActivity r = new ReflectionActivity(60);
        ListeningActivity l = new ListeningActivity(60);

        do
        {
            System.Console.WriteLine("1) Breathing Activity");
            System.Console.WriteLine("2) Reflection Activity");
            System.Console.WriteLine("3) Listening Activity");
            System.Console.WriteLine("4) Exit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                b.doit();
            }
            if (input == "2")
            {
                r.doit();
            }
            if (input == "3")
            {
                l.doit();
            }
             if (input == "4")
            {
                Environment.Exit(0);
            }
        } while (true);
    }
}

