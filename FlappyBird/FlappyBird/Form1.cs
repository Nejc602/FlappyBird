namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 0;
        int gravity = 10;
        int score = 0;
        static Random random = new Random();
        int gap = 225;

        bool isGameActive = false;

        public Form1()
        {
            InitializeComponent();

            startButton.Visible = true;
            exitButton.Visible = true;

            gameTimer.Stop();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            exitButton.Enabled = false;
            startButton.Visible = false;
            exitButton.Visible = false;

            pipeSpeed = 10;
            gravity = 10;
            score = 0;
            isGameActive = true;

            flappyBird.Top = this.ClientSize.Height / 2;
            pipeBottom.Left = 800;
            pipeTop.Left = 800;

            gameTimer.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreBoard.Text = "Game Over!!";

            // Show buttons again
            startButton.Visible = true;
            exitButton.Visible = true;
            startButton.Enabled = true;
            exitButton.Enabled = true;

            pipeSpeed = 0;
            isGameActive = false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            scoreBoard.Text = "Score: " + score;

            if (pipeBottom.Left < -150 && pipeTop.Left < -150)
            {
                pipeBottom.Left = 800;
                pipeTop.Left = 800;
                int randomHeight = random.Next(100, this.ClientSize.Height - gap - 100);

                pipeTop.Top = randomHeight - pipeTop.Height;
                pipeBottom.Top = randomHeight + gap;

                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 10) pipeSpeed = 15;
            if (score > 20) pipeSpeed = 20;


            if (flappyBird.Top > this.ClientSize.Height - flappyBird.Height)
            {
                endGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (isGameActive && e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (isGameActive && e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
    }
}
