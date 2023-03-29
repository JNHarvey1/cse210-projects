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

        var Jungle = new JungleMap(player);

    }
}