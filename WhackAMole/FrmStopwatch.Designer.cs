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
            SuspendLayout();
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(83, 77);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(38, 15);
            lblTimeElapsed.TabIndex = 0;
            lblTimeElapsed.Text = "label1";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(65, 115);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClick;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(65, 154);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStopClick;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(65, 192);
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
            // FrmStopwatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 450);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimeElapsed);
            Name = "FrmStopwatch";
            Text = "Stopwatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimeElapsed;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrStopwatch;
    }
}