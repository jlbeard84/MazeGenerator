using MazeGenerator.Extensions;
using MazeGenerator.Interfaces;
using System.Drawing;

namespace MazeGenerator.UnitOfWorks
{
    public class DrawGridUoW
    {
        private readonly IGrid _gridItem;
        private readonly int _cellSize;

        private readonly Color _defaultPenColor = Color.Black;
        private readonly Color _defaultBackgroundColor = Color.White;

        public DrawGridUoW(
            IGrid gridItem,
            int cellSize = 5)
        {
            _gridItem = gridItem;
            _cellSize = cellSize;
        }

        public Bitmap Execute()
        {
            var image = new Bitmap(
                _gridItem.Width * _cellSize + 5,
                _gridItem.Height * _cellSize + 5);

            var graphics = Graphics.FromImage(image);

            graphics.Clear(_defaultBackgroundColor);

            var pen = new Pen(_defaultPenColor);

            for (var i = 0; i < _gridItem.Width; i++)
            {
                for (var j = 0; j < _gridItem.Height; j++)
                {
                    if (_gridItem.GetCell(i, j).North)
                    {
                        graphics.DrawLine(
                            pen, 
                            new Point(i * _cellSize, j * _cellSize), 
                            new Point((i * _cellSize) + _cellSize, j * _cellSize));
                    }

                    if (_gridItem.GetCell(i, j).South)
                    {
                        graphics.DrawLine(
                            pen, 
                            new Point(i * _cellSize, (j * _cellSize) + _cellSize), 
                            new Point((i * _cellSize) + _cellSize, (j * _cellSize) + _cellSize));
                    }

                    if (_gridItem.GetCell(i, j).West)
                    {
                        graphics.DrawLine(
                            pen, 
                            new Point(i * _cellSize, j * _cellSize), 
                            new Point(i * _cellSize, (j * _cellSize) + _cellSize));
                    }

                    if (_gridItem.GetCell(i, j).East)
                    {
                        graphics.DrawLine(
                            pen, 
                            new Point((i * _cellSize) + _cellSize, j * _cellSize), 
                            new Point((i * _cellSize) + _cellSize, (j * _cellSize) + _cellSize));
                    }
                }
            }

            return image;
        }
    }
}