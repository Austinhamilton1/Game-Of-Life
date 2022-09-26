namespace Game_Of_Life
{
    public partial class Canvas : Form
    {
        SolidBrush brush = new SolidBrush(Color.Black);
        Graphics g;
        Cell[,] cells = new Cell[1000 / 20, 1000 / 20];
        bool isPlaying = false;
        bool editMode = true;

        public Color AliveColor { get; set; }
        public Color DeadColor { get; set; }

        public Canvas()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            for(int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = new Cell(i, j);
                }
            }

            AliveColor = Color.White;
            DeadColor = Color.Black;
        }

        public void PaintCells()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j].PaintCell(brush, g, AliveColor, DeadColor);
                }
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            PaintCells();
        }

        private Cell[] GetNeighbors (Cell cell)
        {
            int above, below, right, left;

            above = cell.Y - 1;
            below = cell.Y + 1;
            right = cell.X + 1;
            left = cell.X - 1;

            if (above < 0)
                above = cells.GetLength(1) - 1;

            if (below > cells.GetLength(1) - 1)
                below = 0;

            if (right > cells.GetLength(0) - 1)
                right = 0;

            if(left < 0)
                left = cells.GetLength(0) - 1;

            Cell[] neighbors = {
                cells[left, above],
                cells[cell.X, above],
                cells[right, above],
                cells[right, cell.Y],
                cells[right, below],
                cells[cell.X, below],
                cells[left, below],
                cells[left, cell.Y],
            };

            return neighbors;
        }

        private bool IsCellAlive(Cell cell)
        {
            int aliveNeighbors = 0;
            Cell[] neighbors = GetNeighbors(cell);

            foreach(Cell neighbor in neighbors)
            {
                if (neighbor.IsAlive)
                    aliveNeighbors++;
            }

            if (cell.IsAlive && aliveNeighbors < 2)
                return false;
            else if (cell.IsAlive && aliveNeighbors == 2 || cell.IsAlive && aliveNeighbors == 3)
                return true;
            else if (cell.IsAlive && aliveNeighbors > 3)
                return false;
            else if (!cell.IsAlive && aliveNeighbors == 3)
                return true;
            else
                return false;
        }

        private void NextState()
        {
            bool[,] alive = new bool[cells.GetLength(0), cells.GetLength(1)];
            for(int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j = 0; j < cells.GetLength(1); j++)
                {
                    alive[i, j] = IsCellAlive(cells[i, j]);
                }
            }

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j].IsAlive = alive[i, j];
                }
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            NextState();
            PaintCells();
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!isPlaying)
                {
                    Clock.Enabled = true;
                    editMode = false;
                }
                else
                {
                    Clock.Enabled = false;
                    editMode = true;
                }
                isPlaying ^= true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Menu menu = new Menu(this);

                menu.ShowDialog();
            }
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (editMode)
            {
                Point position = this.PointToClient(Cursor.Position);

                int x = position.X / 20;
                int y = position.Y / 20;

                cells[x, y].IsAlive ^= true;

                PaintCells();
            }
        }

        public void Randomize(int randomFactor)
        {
            if (randomFactor > 0)
            {
                Random random = new Random();
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        int value = random.Next(100);
                        if (value < randomFactor)
                            cells[i, j].IsAlive = true;
                    }
                }
            }
        }

        public void ClearBoard()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j].IsAlive = false;
                }
            }
        }
    }
}