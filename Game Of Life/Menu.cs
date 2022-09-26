using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Game_Of_Life
{
    public partial class Menu : Form
    {
        private Canvas canvas;
        public int Random { get; set; }
        public Color AliveColor { get; set; }
        public Color DeadColor { get; set; }
        public Menu(Canvas c)
        {
            InitializeComponent();

            string message = string.Empty;
            message += "Use this number to change\n";
            message += "the chance of a cell being\n";
            message += "alive or dead(100 means it has\n";
            message += "a 100% chance of being alive).\n";
            message += "Leave it at 0 to not change anything.";

            randomLabel.Text = message;

            canvas = c;

            if (canvas.AliveColor == Color.White)
                whiteOption.Checked = true;
            else if (canvas.AliveColor == Color.Red)
                redOption.Checked = true;
            else if(canvas.AliveColor == Color.Green)
                greenOption.Checked = true;
            else if(canvas.AliveColor == Color.Yellow)
                yellowOption.Checked = true;
            else if(canvas.AliveColor == Color.Pink)
                pinkOption.Checked = true;

            if(canvas.DeadColor == Color.Black)
                blackOption.Checked = true;
            else if(canvas.DeadColor == Color.Blue)
                blueOption.Checked = true;
            else if(canvas.DeadColor == Color.Gray)
                grayOption.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (blackOption.Checked)
                DeadColor = Color.Black;
            else if (blueOption.Checked)
                DeadColor = Color.Blue;
            else if (grayOption.Checked)
                DeadColor = Color.Gray;

            if(whiteOption.Checked)
                AliveColor = Color.White;
            else if(redOption.Checked)
                AliveColor = Color.Red;
            else if(greenOption.Checked)
                AliveColor = Color.Green;
            else if(yellowOption.Checked)
                AliveColor = Color.Yellow;
            else if(pinkOption.Checked)
                AliveColor = Color.Pink;

            try
            {
                if (randomFactor.Text == string.Empty)
                    Random = 0;
                else
                    Random = Convert.ToInt32(randomFactor.Text);

                if (Random < 0 || Random > 100)
                    throw new Exception();

                canvas.AliveColor = AliveColor;
                canvas.DeadColor = DeadColor;

                canvas.Randomize(Random);

                canvas.PaintCells();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The random factor must be an integer between 0 and 100.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canvas.ClearBoard();
            canvas.PaintCells();
            this.Close();
        }
    }
}
