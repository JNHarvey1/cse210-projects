using System;
using System.Text;

public class Area
{
    public string Name {get; set;} = Text.DefaultAreaName;

    public string Description {get; set;} = Text.DefaultAreaDesc;
    public Dictionary<Directions, int> Neighbors {get; set;} = new()
    {
        {Directions.North, -1},
        {Directions.East, -1},
        {Directions.South, -1},
        {Directions.West, -1},
        {Directions.None, -1},
    };
    public bool Visited {get; set;}
    

    public override string ToString()
    {
        var txt = new Text();
        var sb = new StringBuilder();
        if (Visited)
            sb.Append(string.Format(Text.AreaOld, Name));
        else
            sb.Append(string.Format(Text.AreaNew, Name));
        
        var names = Enum.GetNames(typeof(Directions));
        var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();
        var description = string.Format(Description, txt.JoinedWordList(directions, Text.And));
        sb.Append(description);
        return sb.ToString();
    }
    
}
