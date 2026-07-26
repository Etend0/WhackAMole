using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Elijah Hodge
 * CST - 250
 * 07/24/2026
 * Whack-A-Mole
 * Activity 5
 */

namespace WhackAMole
{
    public partial class FrmStopwatch : Form
    {
        // Class level variable to hold the timer's time
        TimeSpan timeElapsed = TimeSpan.FromMinutes(1);
        // Create a new Random object to generate numbers
        Random random = new Random();
        // Class level variable to hold the score
        int score = 0;
        // Class level variable to hold the lives
        int lives = 3;
        // Class level variable to hold the current level
        int currLevel = 1;
        // Class level variable to accumulate for button movement
        int moveAccumulator = 0;
        // Class level variable to control how often the buttons move depending on the level
        int moveInterval = 3000;
        // Class level variable to hold a minimum points for the player to earn an extra life so that they can't just click the target repeatedly to earn infinite lives
        int pointsReachedForExtraLife = 0;
        // Class level variable to hold how many targets the player missed
        int targetsMissed = 0;

        /// <summary>
        /// Constructor for FrmStopwatch
        /// </summary>
        public FrmStopwatch()
        {
            InitializeComponent();

            // Set the score label to show the initial score
            lblScore.Text = score.ToString();
            // Set the lives label to show the initial lives
            lblLives.Text = lives.ToString();
            // Set the level label to show the initial level
            lblLevel.Text = currLevel.ToString();
            // Set the missed targets label to show the initial missed targets
            lblMissedTargets.Text = targetsMissed.ToString();

            // Set timer interval to fixed value for smoothness
            tmrStopwatch.Interval = 100;
        }

        /// <summary>
        /// Click Event Handler for btnStart
        /// Starts the timer
        /// </summary>
        /// <param name="sener"></param>
        /// <param name="e"></param>
        private void BtnStartClickEH(object sener, EventArgs e)
        {
            // Start the timer
            tmrStopwatch.Start();
        }

        /// <summary>
        /// Click Event Handler for btnStop
        /// Stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopClickEH(object sender, EventArgs e)
        {
            // Stop the timer
            tmrStopwatch.Stop();
        }

        /// <summary>
        /// Tick Event Handler for tmrStopwatch
        /// Updates the timeElapsed variable and the label
        /// Moves btnTarget every three seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrStopwatchTickEH(object sender, EventArgs e)
        {
            // Always use the fixed interval
            int interval = tmrStopwatch.Interval;
            // Subtract the timer's interval from timeElapsed
            timeElapsed = timeElapsed.Subtract(TimeSpan.FromMilliseconds(interval));
            // Accumulate time for button movement
            moveAccumulator += interval;
            // If timeElapsed is less than or equal to zero, stop the timer
            if (timeElapsed <= TimeSpan.Zero)
            {
                // Set the time to zero
                timeElapsed = TimeSpan.Zero;
                // Show the time elapsed on the label with the correct format
                lblTimeElapsed.Text = timeElapsed.ToString(@"hh\:mm\:ss");
                // Show a message box with the final score
                tmrStopwatch.Stop();

                // Show a message box with the final score and level reached
                MessageBox.Show("Level complete! Your current score is: " + score.ToString(), "Good Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Increment the level
                currLevel++;
                // Update the level label
                lblLevel.Text = currLevel.ToString();
                // Calculate the move interval based on the current level
                moveInterval = 3000 - (currLevel - 1) * 400;
                // Ensure the move interval does not go below 600 ms
                if (moveInterval < 600) moveInterval = 600;
                // Reset move accumulator
                moveAccumulator = 0;
                // Reset timeElapsed to 1 minute
                timeElapsed = TimeSpan.FromMinutes(1);
                // Show the reset time on the label with the correct format
                lblTimeElapsed.Text = timeElapsed.ToString(@"hh\:mm\:ss");
                // Start the timer again for the next level
                tmrStopwatch.Start();
            }
            // Show the timeElapsed in lblTime with the correct format
            lblTimeElapsed.Text = timeElapsed.ToString(@"hh\:mm\:ss");
            // Move the target and bomb buttons at the current move interval
            if (timeElapsed.TotalSeconds > 0 && moveAccumulator >= moveInterval)
            {
                // Reset the move accumulator
                moveAccumulator = 0;
                // Select a new location for the top of btnTarget
                btnTarget.Top = random.Next(0, this.Height - btnTarget.Height);
                // Select a new location for the left side of btnTarget
                btnTarget.Left = random.Next(0, this.Width - btnTarget.Width);
                // Get random numbers for the RGB color for the button
                btnTarget.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                // If we can't see the target, it means the player did get it
                if (btnTarget.Visible == false)
                {
                    // Set the target to be visible
                    btnTarget.Visible = true;
                }
                // If the target was already visible, it means the player missed it, so increment the missed target count
                else
                {
                    // If the target was already visible, it means the player missed it, so increment the missed target count
                    targetsMissed++;
                    // Update the missed targets label
                    lblMissedTargets.Text = targetsMissed.ToString();

                    // Check if the player has missed 5 targets, if so decrement lives and reset the missed target count
                    if (targetsMissed >= 5)
                    {
                        // Reset the missed target count
                        targetsMissed = 0;
                        // Update the missed targets label
                        lblMissedTargets.Text = targetsMissed.ToString();
                        // Call the decrement lives method to penalize the player for missing too many targets
                        DecrementLives();
                    }
                }

                // Select a new location for the top of btnBomb
                btnBomb.Top = random.Next(0, this.Height - btnBomb.Height);
                // Select a new location for the left side of btnBomb
                btnBomb.Left = random.Next(0, this.Width - btnBomb.Width);
                // Get random numbers for the RGB color for the button
                btnBomb.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                // Set the bomb to be visible
                btnBomb.Visible = true;
            }
        } // End of TmrStopwatchTickEH

        /// <summary>
        /// Click Event Handler for btnReset
        /// Reset the timer and related variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetClickEH(object sender, EventArgs e)
        {
            // Stop the timer
            tmrStopwatch.Stop();
            // Reset timeElapsed to 1 minute
            timeElapsed = TimeSpan.FromMinutes(1);
            // Show the reset time on the label
            lblTimeElapsed.Text = timeElapsed.ToString(@"hh\:mm\:ss");
            // Reset the score
            score = 0;
            // Update the score label
            lblScore.Text = score.ToString();
            // Reset the lives
            lives = 3;
            // Update the lives label
            lblLives.Text = lives.ToString();
            // Reset the level
            currLevel = 1;
            // Update the level label
            lblLevel.Text = currLevel.ToString();
            // Set the missed targets count to zero
            targetsMissed = 0;
            // Set the missed targets label to show the initial missed targets
            lblMissedTargets.Text = targetsMissed.ToString();
            // Reset timer interval to default
            tmrStopwatch.Interval = 100;
            // Reset move interval
            moveInterval = 3000;
            // Reset the accumulator
            moveAccumulator = 0;
        }

        /// <summary>
        /// Click Event Handler for btnTarget to hide the target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTargetClickEH(object sender, EventArgs e)
        {
            // Hide the target
            btnTarget.Visible = false;
            // Increment the score
            score++;
            // Update the score label
            lblScore.Text = score.ToString();
            // Set the missed targets count to zero
            targetsMissed = 0;
            // Update the missed targets label
            lblMissedTargets.Text = targetsMissed.ToString();

            // Check if the score is a multiple of 50, increment lives left if the player hasn't already earned an extra life for that score
            if (score % 50 == 0 && pointsReachedForExtraLife < score)
            {
                // Increment lives
                lives++;
                // Update the lives label
                lblLives.Text = lives.ToString();
                // Update the pointsReachedForExtraLife to the current score to prevent multiple lives being earned for the same score
                pointsReachedForExtraLife = score;
            }
        }

        /// <summary>
        /// Click Event Handler for FrmStopwatch to penalize the player for clicking anywhere on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmClickEH(object sender, EventArgs e)
        {
            // Check if the score is greater than 0 before decrementing
            if (score > 0)
            {
                // Decrement the score
                score--;
                // Update the score label
                lblScore.Text = score.ToString();
            }
        }

        /// <summary>
        /// Click Event Handler for btnBomb to hide the bomb and decrement the player's lives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBombClickEH(object sender, EventArgs e)
        {
            // Hide the bomb button
            btnBomb.Visible = false;
            // Call the decrement lives method to decrement the players lives
            DecrementLives();
        }

        /// <summary>
        /// Method to decrement the player's lives and check for game over condition
        /// </summary>
        private void DecrementLives()
        {
            // Check if the player has more than 1 life left before decrementing
            if (lives > 1)
            {
                // Decrement lives
                lives--;
                // Update the lives label
                lblLives.Text = lives.ToString();
            }
            else
            {
                // Decrement lives to 0
                lives--;
                // Update the lives label
                lblLives.Text = lives.ToString();
                // Set timeElapsed to zero and stop the timer
                timeElapsed = TimeSpan.Zero;
                // Update the time label
                tmrStopwatch.Stop();
                // Show the time elapsed on the label
                lblTimeElapsed.Text = timeElapsed.ToString(@"hh\:mm\:ss");

                // Show a message box with the final score
                MessageBox.Show("Game over! Your final score is " + score.ToString() + " and your highest level reached is level " + currLevel.ToString(), "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
