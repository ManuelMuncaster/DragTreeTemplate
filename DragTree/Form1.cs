﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        // TODO - create an int variable to track currentRow,
        int currentRow;
        // TODO - create a Stopwatch object called stopwatch (interval 400ms)
        Stopwatch stopwatch;
        // TODO - create a timer on the form called lightTimer 
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO - start the timer
            lightTimer.Enabled = true;
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            // TODO - create a switch block that checks currentRow. In each case
            // it will light up the appropriate lights, (labels). 

            // TODO - increment the currentRow value by 1

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch

            // TODO - check if the ellapsed time in milliseconds is > 0. 
            // If yes show the time.
            // If no show "FOUL START" 

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch

            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen

            // TODO - reset row value and timeLabel text

        }

    }
}
