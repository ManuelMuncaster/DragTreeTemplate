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
        // TODO - create a Stopwatch object called stopwatch
        Stopwatch stopwatch = new Stopwatch();

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
            switch (currentRow)
            {
                case 1:
                    row1col1.BackColor = Color.Yellow;
                    row1col2.BackColor = Color.Yellow;
                    break;
                case 2:
                    row2col1.BackColor = Color.Yellow;
                    row2col2.BackColor = Color.Yellow;
                    break;
                case 3:
                    row3col1.BackColor = Color.Yellow;
                    row3col2.BackColor = Color.Yellow;
                    break;
                case 4:
                    row4col1.BackColor = Color.LawnGreen;
                    row4col2.BackColor = Color.LawnGreen;
                    stopwatch.Start();
                    break;
            }
            // TODO - increment the currentRow value by 1
            currentRow++;
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            // TODO - stop the stopwatch
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timeLabel.Text = "0." + (stopwatch.ElapsedMilliseconds).ToString("000");
            }
            else
            {
                timeLabel.Text = "False Start!";
            }

            // TODO - check if the ellapsed time in milliseconds is > 0. 
           
            {

            }
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
