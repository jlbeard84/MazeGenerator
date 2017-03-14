using MazeGenerator.Interfaces;

namespace MazeGenerator.Objects
{
    public class Cell : ICell
    {
        public Cell(int intX, int intY)
        {
            X = intX;
            Y = intY;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public bool North { get; set; } = true;

        public bool South { get; set; } = true;

        public bool East { get; set; } = true;

        public bool West { get; set; } = true;

        public bool IsStartPoint { get; set; } = false;
    }
}