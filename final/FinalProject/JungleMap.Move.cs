using System;

public partial class JungleMap
{
    public Area CurrentArea {get; set;}

    public void GoToArea(int index)
    {
        if (CurrentArea != null)
            CurrentArea.Visited = true;
        CurrentArea = Areas[index];
    }

    public void GoToStartingArea()
    {
        GoToArea(_rand.Next(0, Areas.Length));
    }
}