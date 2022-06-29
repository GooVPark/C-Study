namespace Project3
{
    struct Vector 
    {
        public int x;
        public int y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class Form1 : Form
    {
        private int margin = 40;
        private int cellSize = 30;
        private int stoneSize = 28;

        private int[,] grid = new int[19, 19];

        bool isBlackTurn = true;
        Graphics cursor;
        Rectangle cursorRect;
        Point cursorPosition;
        List<Vector> directions = new List<Vector>()
        { new Vector(0, -1), new Vector(1, -1), new Vector(1, 0), new Vector(1, 1), new Vector(0, 1), new Vector(-1, 1), new Vector(-1, 0), new Vector(-1, -1) };

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;
            ClientSize = new Size(2 * margin + 18 * cellSize, 2 * margin + 18 * cellSize);

            cursor = this.CreateGraphics();
            cursorRect = new Rectangle(cursorPosition.X, cursorPosition.Y, 20, 20);
        }

        public void NewGame()
        {
            this.Invalidate();

            for(int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    grid[i, j] = 0;
                }
            }

            isBlackTurn = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            #region DrawBoard
            Graphics line = this.CreateGraphics();
            Pen linePen = new Pen(Color.Black);
            Pen borderPen = new Pen(Color.Black, 3);

            Graphics dot = this.CreateGraphics();
            Brush dotBrush = new SolidBrush(Color.Black);

            for (int i = 0; i < 19; i++)
            {
                if (i == 0 || i == 18)
                {
                    line.DrawLine(borderPen, new Point(margin + cellSize * i, margin), new Point(margin + cellSize * i, margin + 18 * cellSize));
                    line.DrawLine(borderPen, new Point(margin, margin + cellSize * i), new Point(margin + 18 * cellSize, margin + cellSize * i));
                }
                else
                {
                    line.DrawLine(linePen, new Point(margin + cellSize * i, margin), new Point(margin + cellSize * i, margin + 18 * cellSize));
                    line.DrawLine(linePen, new Point(margin, margin + cellSize * i), new Point(margin + 18 * cellSize, margin + cellSize * i));
                }
            }


            for (int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    Rectangle rect = new Rectangle(margin + cellSize * 3 + x * 6 * cellSize - 3, (margin + cellSize * 3 + y * 6 * cellSize) - 3, 6, 6);
                    dot.DrawEllipse(linePen, rect);
                    dot.FillEllipse(dotBrush, rect);
                }
            }
            #endregion


            #region DrawCursor
            cursor.DrawRectangle(linePen, cursorRect);
            cursor.FillRectangle(new SolidBrush(Color.White), cursorRect);
            #endregion

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { 
            int gridIndexX = (e.Location.X - margin + cellSize / 2) / cellSize;
            int gridIndexY = (e.Location.Y - margin + cellSize / 2) / cellSize;
            int positionX = gridIndexX * cellSize + margin;
            int positionY = gridIndexY * cellSize + margin;

            if (grid[gridIndexX, gridIndexY] != 0)
            {
                MessageBox.Show(string.Format("이미 {0}돌이 있습니다.", grid[gridIndexX, gridIndexY] == 1 ? "흑" : "백"));
                return;
            }

            Graphics stone = this.CreateGraphics();
            Pen linePen = new Pen(Color.Black);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush WhiteBrush = new SolidBrush(Color.White);

            Rectangle stoneRect = new Rectangle(positionX - stoneSize/ 2, positionY - stoneSize / 2, stoneSize, stoneSize);

            if (isBlackTurn)
            {
                stone.FillEllipse(blackBrush, stoneRect);
                grid[gridIndexX, gridIndexY] = 1;
            }
            else
            {
                stone.FillEllipse(WhiteBrush, stoneRect);
                grid[gridIndexX, gridIndexY] = 2;
            }
            
            stone.DrawEllipse(linePen, stoneRect);

            if(Check(gridIndexX, gridIndexY, isBlackTurn))
            {
                DialogResult result =  MessageBox.Show("재시작", string.Format("{0} 승리!", isBlackTurn ? "흑" : "백"), MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) NewGame();
                else this.Close();
                return;
            }
            ConsoleUpdate();
            isBlackTurn = !isBlackTurn;   
        }

        private bool Check(int x, int y, bool isBlackTurn)
        {
            int count1 = 0;
            int count2 = 0;
            int state = isBlackTurn ? 1 : 2;

            for (int i = 0; i < 4; i++)
            {
                count1 = Find(x, y, directions[i], 0, state);
                count2 = Find(x, y, directions[i + 4], 0, state);

                if (count1 + count2 >= 4) return true; 
            }

            grid[x, y] = state;
            return false;
        }

        private int Find(int x, int y, Vector direction, int count, int state)
        {
            int gridX = x + direction.x;
            int gridY = y + direction.y;
            
            if (gridX < 0 || gridX > 18 || gridY < 0 || gridY > 18) return count;

            if (grid[gridX, gridY] != state) return count;
            else return Find(gridX, gridY, direction, count + 1, state);
        }

        private void ConsoleUpdate()
        {
            Console.Clear();
            for (int y = 0; y < 19; y++)
            {
                for(int x = 0; x < 19; x++)
                {
                    Console.Write("{0, 2}", grid[x, y]);
                }
                Console.WriteLine();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cursorPosition.X = e.X;
            cursorPosition.Y = e.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cursorRect.X = cursorPosition.X;
            cursorRect.Y = cursorPosition.Y;
        }
    }
}