using System;

public class Go : Action
{
    public override string Name => Text.Go;

    private readonly JungleMap _junglemap;

    public Go(JungleMap junglemap)
    {
        _junglemap =  junglemap;
    }

    public override void Execute(string[] args)
    {
        var currentArea = _junglemap.CurrentArea;

        var dir = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();

        Enum.TryParse(dir, out Directions newDirection);

        var nextAreaIndex = currentArea.Neighbors[newDirection];

        if(nextAreaIndex == -1 || newDirection == Directions.None)
            Console.WriteLine(Text.GoError);
        else
            _junglemap.GoToArea(nextAreaIndex);
    }

}