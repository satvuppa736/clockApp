using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockApp
{
    public partial class HexClock : UserControl
    {
        int hh, mm, ss;
        string time = "";

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

        public HexClock()
        {
            InitializeComponent();
            hexTimer.Start();
        }

        private void hexTimer_Tick(object sender, EventArgs e)
        {
            time = null;
            hh = DateTime.Now.Hour;
            mm = DateTime.Now.Minute;
            ss = DateTime.Now.Second;

            time += "#";
            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;
            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;
            hexLabel.Text = time;

            Color colour = (Color)ColorTranslator.FromHtml(time);
            BackColor = colour;

            Point labelLocation = new Point((this.Width / 2) - hexLabel.Width / 2, (this.Height / 2) - hexLabel.Height / 2);
            hexLabel.Location = labelLocation;
        }
    }
}
