using System;
class Program
{
    static void Main(string[] args)
    {
        var titles = new TitleCards();
        Console.WriteLine(titles.title);
        Console.WriteLine();

        var text = new Text();
        System.Console.WriteLine(text.ChooseName);
        string name = Console.ReadLine();

        if (name == string.Empty)
            name = text.DefaultName;
        var player = new Player(name);

        Console.WriteLine("Welcome {0}", player.Name);

        var jungle = new JungleMap(player);
        jungle.CreateAreas(3, 3);

        jungle.GoToStartingArea();

        Actions.Instance.Register(new Go(jungle));

        var run = true;

        Area lastArea = null;

        while(run)
        {
            if (lastArea != jungle.CurrentArea)
            {
                Console.WriteLine(jungle.CurrentArea.ToString());
                lastArea = jungle.CurrentArea;
            }

            Console.WriteLine(Text.WhatToDo);

            var input = Console.ReadLine().ToLower();
            if(input == Text.Quit)
                run = false;
            else
                Actions.Instance.Execute(input.Split(" "));


        }


    }
}