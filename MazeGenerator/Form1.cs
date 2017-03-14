using System;
using System.Drawing;
using System.Windows.Forms;
using MazeGenerator.Extensions;
using MazeGenerator.Objects;
using MazeGenerator.UnitOfWorks;

namespace MazeGenerator
{
    public partial class Form1 : Form
    {
        private static Image _gridImage;
        private static Random _random;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gridSize = Convert.ToInt32(sizeTextBox.Text);
            var cellSize = Convert.ToInt32(cellSizeTextBox.Text);

            var gridItem = new Grid(
                _random,
                gridSize, 
                gridSize);

            gridItem.Generate();

            var drawUoW = new DrawGridUoW(gridItem, cellSize);
            _gridImage = drawUoW.Execute();

            pictureBox1.Image = _gridImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}