using MazeGenerator.Interfaces;
using System.Collections.Generic;

namespace MazeGenerator.Extensions
{
    public static class GridExtensions
    {
        private static void VisitCell(
            this IGrid grid,
            ICell currentCell)
        {
            var neighbors = GetUnvisitedNeighbors(
                grid,
                currentCell.X,
                currentCell.Y);

            if (neighbors.Count > 0)
            {
                var nextNeighbor = grid.Randomizer.Next(0, neighbors.Count - 1);

                var x = 0;

                while (x < 50)
                {
                    nextNeighbor = grid.Randomizer.Next(0, neighbors.Count);
                    x++;
                }

                var tmpNeighbor = neighbors[nextNeighbor];

                CarveCells(
                    grid,
                    currentCell,
                    tmpNeighbor);

                grid.CellStack.Push(tmpNeighbor);
            }
            else
            {
                grid.CellStack.Pop();
            }

            if (grid.CellStack.Count > 0)
            {
                VisitCell(
                    grid,
                    grid.CellStack.Peek());
            }
        }

        private static void CarveCells(
            this IGrid grid,
            ICell cellA,
            ICell cellB)
        {
            if (cellA.X > cellB.X)
            {
                cellA.West = false;
                cellB.East = false;
            }
            else if (cellA.X < cellB.X)
            {
                cellA.East = false;
                cellB.West = false;
            }

            if (cellA.Y < cellB.Y)
            {
                cellA.South = false;
                cellB.North = false;
            }
            else if (cellA.Y > cellB.Y)
            {
                cellA.North = false;
                cellB.South = false;
            }
        }

        private static List<ICell> GetUnvisitedNeighbors(
            this IGrid grid,
            int x,
            int y)
        {
            var neighbors = new List<ICell>();

            if (IsValidCell(
                grid,
                x - 1,
                y))
            {
                if (!grid.CellGrid[x - 1, y].BeenVisited())
                {
                    neighbors.Add(grid.CellGrid[x - 1, y]);
                }
            }

            if (IsValidCell(
                grid,
                x + 1,
                y))
            {
                if (!grid.CellGrid[x + 1, y].BeenVisited())
                {
                    neighbors.Add(grid.CellGrid[x + 1, y]);
                }
            }

            if (IsValidCell(
                grid,
                x,
                y - 1))
            {
                if (!grid.CellGrid[x, y - 1].BeenVisited())
                {
                    neighbors.Add(grid.CellGrid[x, y - 1]);
                }
            }

            if (IsValidCell(
                grid,
                x,
                y + 1))
            {
                if (!grid.CellGrid[x, y + 1].BeenVisited())
                {
                    neighbors.Add(grid.CellGrid[x, y + 1]);
                }
            }

            return neighbors;
        }

        private static bool IsValidCell(
            this IGrid grid,
            int x,
            int y)
        {
            var isValid = true;

            if (x < 0 || x >= grid.Width)
            {
                isValid = false;
            }
            else if (y < 0 || y >= grid.Height)
            {
                isValid = false;
            }

            return isValid;
        }

        public static void Generate(
            this IGrid grid)
        {
            int startX = 0, startY = 0;

            startX = grid.Randomizer.Next(0, grid.Width);
            startY = grid.Randomizer.Next(0, grid.Height);

            grid.CellStack.Push(
                grid.CellGrid[startX, startY]);

            VisitCell(
                grid,
                grid.CellGrid[startY, startY]);

            var startEdge = grid.Randomizer.Next(0, 2);

            if (startEdge == 0)
            {
                var begX = grid.Randomizer.Next(0, grid.Width);
                var endX = grid.Randomizer.Next(0, grid.Width);

                grid.CellGrid[begX, 0].North = false;
                grid.CellGrid[endX, grid.Height - 1].South = false;
            }
            else if (startEdge == 1)
            {
                var begY = grid.Randomizer.Next(0, grid.Height);
                var endY = grid.Randomizer.Next(0, grid.Height);

                grid.CellGrid[0, begY].West = false;
                grid.CellGrid[grid.Width - 1, endY].East = false;
            }
        }

        public static ICell GetCell(
            this IGrid grid,
            int x,
            int y)
        {
            return grid.CellGrid[x, y];
        }

        public static bool IsNorthEdge(
            this IGrid grid,
            int x,
            int y)
        {
            return y == 0;
        }

        public static bool IsSouthEdge(
            this IGrid grid,
            int x,
            int y)
        {
            return y + 1 >= grid.Height;
        }

        public static bool IsEastEdge(
            this IGrid grid,
            int x,
            int y)
        {
            return x + 1 >= grid.Width;
        }

        public static bool IsWestEdge(
            this IGrid grid,
            int x,
            int y)
        {
            return x == 0;
        }
    }
}