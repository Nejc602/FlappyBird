namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;
        static Random random = new Random();
        int gap = 225;

        public Form1()
        {
            InitializeComponent();
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreBoard.Text = "Game Over!!";
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreBoard.Text = "Score" + score;

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
                    flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();

            }

            if (score > 10)
            {
                pipeSpeed = 15;
            }

            if (score > 20)
            {
                pipeSpeed = 20;
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }


        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

    }
}
