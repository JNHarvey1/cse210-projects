using System;

public partial class JungleMap
{
    private int CalculateAreaIndex(int c, int r)
    {
        return Math.Clamp(c, -1, Width) + Math.Clamp(r, -1, Height) * Width;

    }
    public void CreateAreas(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Areas = new Area[total];

        for (var i = 0; i < total; i++)
        {
            var tmpArea = new Area();

            var c = i % Width;
            var r = i / Width;

            tmpArea.Name = String.Format(Text.DefaultAreaName, i, c, r);

            if(c < Width - 1)
            {
                tmpArea.Neighbors[Directions.East] = CalculateAreaIndex(c + 1, r);
            }
            if(c > 0)
            {
                tmpArea.Neighbors[Directions.West] = CalculateAreaIndex(c - 1, r);
            }
            if(r < Height - 1)
            {
                tmpArea.Neighbors[Directions.South] = CalculateAreaIndex(c, r + 1);
            }
            if(r > 0)
            {
                tmpArea.Neighbors[Directions.North] = CalculateAreaIndex(c, r - 1);
            }

            Areas[i] = tmpArea;
        }
    }
}