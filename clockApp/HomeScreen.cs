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
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();             
        }

        private void clockBox_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ClockScreen hs = new ClockScreen();
            f.Controls.Add(hs);
        }

        private void hexBox_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HexClock hc = new HexClock();
            f.Controls.Add(hc);
        }

        private void stopWatchBox_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            StopWatch sw = new StopWatch();
            f.Controls.Add(sw);
        }
    }
}
