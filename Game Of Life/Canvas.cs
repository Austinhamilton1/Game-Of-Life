namespace Game_Of_Life
{
    public partial class Canvas : Form
    {
        SolidBrush brush = new SolidBrush(Color.Black);
        Graphics g;
        Cell[,] cells = new Cell[1000 / 20, 1000 / 20];

        public Canvas()
        {
            InitializeComponent();
        }

        public void Init()
        {
            for(int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = new Cell(i, j);
                }
            }
        }

        public void PaintCells()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j].PaintCell(brush, g);
                }
            }
        }
    }
}