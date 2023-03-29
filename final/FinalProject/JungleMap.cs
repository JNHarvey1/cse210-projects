using System;

public partial class JungleMap
{
    public Player Player {get; }
    private readonly Random _rand = new(1234);

    public JungleMap(Player player)
    {
        Player = player;
    }
}