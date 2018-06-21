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
            Point labelLocation = new Point((this.Width / 2) - clockLabel.Width / 2, 115);
            clockLabel.Location = labelLocation;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (startStopBtn.Text == "START")
            {
                stopWatchTimer.Start();
                start = watch.Elapsed;
                watch.Start();
                startStopBtn.Text = "STOP";
                startStopBtn.ForeColor = Color.Red;
                
                resetLapBtn.Text = "LAP";
                resetLapBtn.ForeColor = Color.Yellow;
            }
            else if (startStopBtn.Text == "STOP")
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
            if (resetLapBtn.Text == "RESET")
            {
                watch.Reset();
                clockLabel.Text = "00:00:00.000";
                lapTimeOutput.Items.Clear();
            }
            else if (resetLapBtn.Text == "LAP")
            {
               end = watch.Elapsed;
                TimeSpan elapsed = end - start;
                lapTimeOutput.Items.Add((lapTimeOutput.Items.Count + 1) + ". " + elapsed);

                start = end;

                //TimeSpan lapTIme = (lapTimeOutput.Items 1)
            }
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = Convert.ToString(watch.Elapsed.ToString(@"hh\:mm\:ss\.fff"));
        }
    }
}
