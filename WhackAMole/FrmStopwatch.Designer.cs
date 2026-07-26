namespace WhackAMole
{
    partial class FrmStopwatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTimeElapsed = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            tmrStopwatch = new System.Windows.Forms.Timer(components);
            btnTarget = new Button();
            btnBomb = new Button();
            label1 = new Label();
            label2 = new Label();
            lblLives = new Label();
            label3 = new Label();
            lblScore = new Label();
            label4 = new Label();
            lblMissedTargets = new Label();
            label5 = new Label();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(357, 9);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(38, 15);
            lblTimeElapsed.TabIndex = 0;
            lblTimeElapsed.Text = "label1";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 488);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClickEH;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(93, 488);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStopClickEH;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(174, 488);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnResetClickEH;
            // 
            // tmrStopwatch
            // 
            tmrStopwatch.Enabled = true;
            tmrStopwatch.Interval = 1000;
            tmrStopwatch.Tick += TmrStopwatchTickEH;
            // 
            // btnTarget
            // 
            btnTarget.Location = new Point(196, 128);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(100, 80);
            btnTarget.TabIndex = 4;
            btnTarget.Text = "Target";
            btnTarget.UseVisualStyleBackColor = true;
            btnTarget.Click += BtnTargetClickEH;
            // 
            // btnBomb
            // 
            btnBomb.Location = new Point(492, 195);
            btnBomb.Name = "btnBomb";
            btnBomb.Size = new Size(100, 80);
            btnBomb.TabIndex = 5;
            btnBomb.Text = "Bomb";
            btnBomb.UseVisualStyleBackColor = true;
            btnBomb.Click += btnBombClickEH;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 6;
            label1.Text = "Time Remaining:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Lives:";
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.Location = new Point(54, 9);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(38, 15);
            lblLives.TabIndex = 8;
            lblLives.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 9);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(175, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(38, 15);
            lblScore.TabIndex = 10;
            lblScore.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 9);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 11;
            label4.Text = "Missed Moles:";
            // 
            // lblMissedTargets
            // 
            lblMissedTargets.AutoSize = true;
            lblMissedTargets.Location = new Point(527, 9);
            lblMissedTargets.Name = "lblMissedTargets";
            lblMissedTargets.Size = new Size(38, 15);
            lblMissedTargets.TabIndex = 12;
            lblMissedTargets.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(660, 9);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 13;
            label5.Text = "Current Level:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(746, 9);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(38, 15);
            lblLevel.TabIndex = 14;
            lblLevel.Text = "label6";
            // 
            // FrmStopwatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 523);
            Controls.Add(lblLevel);
            Controls.Add(label5);
            Controls.Add(lblMissedTargets);
            Controls.Add(label4);
            Controls.Add(lblScore);
            Controls.Add(label3);
            Controls.Add(lblLives);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBomb);
            Controls.Add(btnTarget);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimeElapsed);
            Name = "FrmStopwatch";
            Text = "Stopwatch";
            Click += FrmClickEH;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimeElapsed;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrStopwatch;
        private Button btnTarget;
        private Button btnBomb;
        private Label label1;
        private Label label2;
        private Label lblLives;
        private Label label3;
        private Label lblScore;
        private Label label4;
        private Label lblMissedTargets;
        private Label label5;
        private Label lblLevel;
    }
}