namespace MazeGenerator.Interfaces
{
    public interface ICell
    {
        int X { get; set; }

        int Y { get; set; }

        bool North { get; set; }

        bool South { get; set; }

        bool East { get; set; }

        bool West { get; set; }

        bool IsStartPoint { get; set; }
    }
}