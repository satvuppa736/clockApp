using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace clockApp
{
    public partial class StopWatch : UserControl
    {
        Stopwatch watch = new Stopwatch();

        TimeSpan start, end;

        public StopWatch()
        {
            InitializeComponent();
            Point labelLocation = new Point((this.Width / 2) - clockLabel.Width / 2, 115); //centres x but lets y stay at eye level 
            clockLabel.Location = labelLocation;
        }

        private void backButton_Click(object sender, EventArgs e) //close screen and open home screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (startStopBtn.Text == "START")      //if text of left btn is start, change the text of both btns, star the timers
            {
                stopWatchTimer.Start();
                start = watch.Elapsed;
                watch.Start();
                startStopBtn.Text = "STOP";
                startStopBtn.ForeColor = Color.Red;

                resetLapBtn.Text = "LAP";
                resetLapBtn.ForeColor = Color.Yellow;
            }
            else if (startStopBtn.Text == "STOP")  //if text of left button is stop, change the text of both buttons, stop both timers
            {
                stopWatchTimer.Stop();
                watch.Stop();

                startStopBtn.Text = "START";
                startStopBtn.ForeColor = Color.Green;

                resetLapBtn.Text = "RESET";
                resetLapBtn.ForeColor = Color.Red;
            }
        }

        private void resetLapBtn_Click(object sender, EventArgs e)
        {
            if (resetLapBtn.Text == "RESET")    //if right btn text is reset, reset the stopwatch, the label, and the lap output box
            {
                watch.Reset();
                clockLabel.Text = "00:00:00.000";
                lapTimeOutput.Items.Clear();
            }
            else if (resetLapBtn.Text == "LAP") //if right btn is lap, record the end time as the current elapsed time, subtract with the start time and display that time as elapsed in list box
            {
                end = watch.Elapsed;
                TimeSpan elapsed = end - start;
                lapTimeOutput.Items.Add((lapTimeOutput.Items.Count + 1) + ". " + elapsed);

                start = end;

            }
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            //display stopwatch time to 3 digit milliseconds
            clockLabel.Text = Convert.ToString(watch.Elapsed.ToString(@"hh\:mm\:ss\.fff"));
        }
    }
}
