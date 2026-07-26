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
        // Class level variable to hold the timers time
        TimeSpan timeElapsed = new TimeSpan();
        // Create a new Random object to generate numbers
        Random random = new Random();

        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmStopwatch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Event Handler for btnStart
        /// Starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartClickEH(object sender, EventArgs e)
        {
            // Start the stopwatch
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
            // Stop the stopwatch
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
            // Get the interval from tmrStopwatch
            int interval = tmrStopwatch.Interval;
            // Add the timers interval to timeElapsed
            timeElapsed = timeElapsed.Add(TimeSpan.FromMilliseconds(interval));
            // Show the timeElapsed on the label
            lblTimeElapsed.Text = timeElapsed.ToString();
            if (timeElapsed.TotalSeconds % 3 == 0)
            {
                // Select a new location for the top of btnTarget
                // Randomly generate a location for the top of the button
                // between 0 and the form height minus the button height
                btnTarget.Top = random.Next(0, this.Height - btnTarget.Height);
                // Select a new location for the left side of btnTarget
                btnTarget.Left = random.Next(0, this.Width - btnTarget.Width);
                // Get random numbers for the RGB color for the button
                btnTarget.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                // Set the target to be visible
                btnTarget.Visible = true;
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
            // Reset elapsedTime
            timeElapsed = new TimeSpan();
            // Show the reset time on the label
            lblTimeElapsed.Text = timeElapsed.ToString();
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
        }
    }
}
