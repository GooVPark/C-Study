namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle ball;
        Rectangle[] blocks = new Rectangle[100];
        bool[] blockVisible = new bool[100];

        Brush racketColor = new SolidBrush(Color.Red);
        Brush ballColor = new SolidBrush(Color.Gold);
        Brush blockColor = new SolidBrush(Color.Orange);

        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;

        int racketY = 450;
        int racketW = 50;
        int racketH = 10;

        int blockCount = 20;
        int restBlocks = 0;
        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;
        int lastX = 0;
        int lastY = 0;

        double slope = 1;
        double verticalDirection = 1;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            //폼 사이즈
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            g = this.CreateGraphics();

            InitBlocks();
            InitRacket();
            InitBall();
        }

        public void InitBlocks()
        {
            for (int i = 0; i < blockCount; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW, blockY + blockH * (i / 10), blockW - 1, blockH - 1);
            }
            for (int i = 0; i < blockCount; i++)
            {
                blockVisible[i] = true;
            }

            restBlocks = blockCount;
        }

        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + blockCount / 10 * blockW;
            ball.Width = ballW;
            ball.Height = ballH;

            slope = random.Next(1, 20) / 10.0;
            if (random.Next(2) % 2 == 0)
            {
                slope = -slope;
            }

            verticalDirection = 1;
        }

        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            #region Draw Block
            for (int i = 0; i < blockCount; i++)
            {
                if (blockVisible[i]) g.FillRectangle(blockColor, blocks[i]);
            }
            #endregion

            #region Draw Ball
            g.DrawEllipse(pen, ball);
            g.FillEllipse(ballColor, ball);
            #endregion

            #region Draw Racket
            g.FillRectangle(racketColor, racket);
            #endregion
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            lastX = ball.X;
            lastY = ball.Y;

            this.Invalidate();

            double directionX = 0;
            double unit = 1.0;

            directionX = unit / slope;

            ball.X += (int)directionX;
            ball.Y += (int)(verticalDirection * slope * directionX);

            //벽 충돌 체크
            if (ball.X >= formW - ballW || ball.X <= 0)
            {
                slope = -slope;
            }

            //라켓 충돌 체크
            if(ball.Y < 0 || racket.IntersectsWith(ball))
            {
                verticalDirection = -verticalDirection;
            }

            //블럭 충돌 체크
            for(int i = 0; i <= blockCount; i++)
            {
                if (blockVisible[i] && ball.IntersectsWith(blocks[i]))
                {
                    Console.WriteLine("Hit Block: " + blocks[i].X + "  " + blocks[i].Y);
                    if (ball.Y - ballH / 2 <= blocks[i].Y || ball.Y - ballH / 2 >= blocks[i].Y + blockH)
                    {
                        Console.WriteLine("Vertical Hit  Current Pos: " + ball.X + " " + ball.Y + " Last Pos: " + lastX + " " + lastY);
                        verticalDirection = -verticalDirection;
                    }
                    else if (ball.Y - ballH / 2 > blocks[i].Y && ball.Y - ballH / 2 < blocks[i].Y + blockH)
                    {
                        Console.WriteLine("Horizontal Hit Current Pos: " + ball.X + " " + ball.Y + " Last Pos: " + lastX + " " + lastY);
                        slope = -slope;
                    }
                    blockVisible[i] = false;
                    restBlocks--;
                }
            }
            //승리
            if(restBlocks == 0)
            {
                myTimer.Stop();
                DialogResult result = MessageBox.Show("승리. 다음단계?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    blockCount += 10;

                    InitBlocks();
                    InitRacket();
                    InitBall();
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
                return;
            }
            //패배
            if(ball.Y > formH)
            {
                myTimer.Stop();
                DialogResult result = MessageBox.Show("패배. 재시작?" ,"확인", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    blockCount = 20;
                    InitBlocks();
                    InitRacket();
                    InitBall();
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
                return;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            racket.X = e.X - racketW / 2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if(e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }
            Invalidate();
        }
    }
}