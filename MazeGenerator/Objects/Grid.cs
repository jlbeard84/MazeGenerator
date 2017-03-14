using MazeGenerator.Interfaces;
using System;
using System.Collections.Generic;

namespace MazeGenerator.Objects
{
    public class Grid : IGrid
    {
        public Grid(
            Random randomizer,
            int intWidth,
            int intHeight)
        {
            Width = intWidth;
            Height = intHeight;
            Randomizer = randomizer;

            CellGrid = new ICell[intWidth, intHeight];

            for (var i = 0; i < intWidth; i++)
            {
                for (var j = 0; j < intHeight; j++)
                {
                    CellGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public Random Randomizer { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Stack<ICell> CellStack { get; set; } = new Stack<ICell>();

        public ICell[,] CellGrid { get; set; }
    }
}