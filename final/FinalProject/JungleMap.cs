using System;

public partial class JungleMap
{
    public Player Player {get; }
    private readonly Random _rand = new(1234);
    public int Width {get; set;}
    public int Height {get; set;}
    public Area[] Areas {get; private set;}

    public JungleMap(Player player)
    {
        Player = player;
    }
}