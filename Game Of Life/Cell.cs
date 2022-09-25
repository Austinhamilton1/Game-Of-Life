using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    public class Cell
    {
        public int Height { get { return 20; } }
        public int Width { get { return 20; } }
        public int X { get; init; }
        public int Y { get; init; }
        public bool IsAlive { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            IsAlive = false;
        }

        public void PaintCell(SolidBrush brush, Graphics g)
        {
            Rectangle rectangle = new Rectangle(X * 20, Y * 20, Width, Height);

            if (IsAlive)
                brush.Color = Color.White;
            else
                brush.Color = Color.Black;

            g.FillRectangle(brush, rectangle);

        }
    }
}
