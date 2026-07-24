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
        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmStopwatch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Event Handler for btnStart
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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopClick(object sender, EventArgs e)
        {
            // Stop the stopwatch
            tmrStopwatch.Stop();
        }
    }
}
