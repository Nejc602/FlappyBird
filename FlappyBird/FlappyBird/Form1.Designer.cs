namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreBoard = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            startButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.BackgroundImage = Properties.Resources.bird;
            flappyBird.Location = new Point(96, 308);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(79, 62);
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.BackgroundImage = Properties.Resources.pipedown;
            pipeTop.Location = new Point(467, -264);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(192, 555);
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackgroundImage = Properties.Resources.pipe;
            pipeBottom.Location = new Point(411, 597);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(189, 657);
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.BackgroundImage = Properties.Resources.ground;
            ground.Location = new Point(-109, 773);
            ground.Name = "ground";
            ground.Size = new Size(956, 87);
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreBoard
            // 
            scoreBoard.AutoSize = true;
            scoreBoard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            scoreBoard.Location = new Point(41, 26);
            scoreBoard.Name = "scoreBoard";
            scoreBoard.Size = new Size(134, 36);
            scoreBoard.TabIndex = 4;
            scoreBoard.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // startButton
            // 
            startButton.Location = new Point(220, 248);
            startButton.Name = "startButton";
            startButton.Size = new Size(204, 93);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(220, 389);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(204, 93);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(671, 847);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            Controls.Add(scoreBoard);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(flappyBird);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreBoard;
        private System.Windows.Forms.Timer gameTimer;
        private Button startButton;
        private Button exitButton;
    }
}
