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
        private void BtnStartClick(object sender, EventArgs e)
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
        private void BtnStopClick(object sender, EventArgs e)
        {
            // Stop the stopwatch
            tmrStopwatch.Stop();
        }

        /// <summary>
        /// Tick Event Handler for tmrStopwatch
        /// Updates the timeElapsed variable and the label
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
        }

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
    }
}
