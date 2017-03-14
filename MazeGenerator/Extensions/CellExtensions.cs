using MazeGenerator.Enums;
using MazeGenerator.Interfaces;

namespace MazeGenerator.Extensions
{
    public static class CellExtensions
    {
        public static void Carve(
            this ICell cell,
            Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    cell.North = false;
                    break;

                case Direction.South:
                    cell.South = false;
                    break;

                case Direction.East:
                    cell.East = false;
                    break;

                case Direction.West:
                    cell.West = false;
                    break;
            }
        }

        public static bool BeenVisited(
            this ICell cell)
        {
            return
                cell.North == false ||
                cell.South == false ||
                cell.East == false ||
                cell.West == false;
        }
    }
}