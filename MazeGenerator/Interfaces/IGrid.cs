using System;
using System.Collections.Generic;

namespace MazeGenerator.Interfaces
{
    public interface IGrid
    {
        Random Randomizer { get; set; }

        int Width { get; set; }

        int Height { get; set; }

        Stack<ICell> CellStack { get; set; }

        ICell[,] CellGrid { get; set; }
    }
}