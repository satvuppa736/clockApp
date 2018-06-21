using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace clockApp
{
    public partial class ClockScreen : UserControl
    {

        public static bool hourMode;
        public ClockScreen()
        {
            InitializeComponent();
            clockTimer.Start();
            datelabel.Text = Convert.ToString(DateTime.Now.Day) //displays the current date
                + "/" + Convert.ToString(DateTime.Now.Month)
                + "/" + Convert.ToString(DateTime.Now.Year);
            clockLabel.Text = "";                              //resets clock label when starting the app

            clockTimer.Tick += new EventHandler(this.clockTimer_Tick);

            XmlDocument doc = new XmlDocument();
            doc.Load("Settings.xml");

            string colour = doc.SelectSingleNode("settings/color").InnerText;


            if (doc.SelectSingleNode("settings/hourMode").InnerText == "false")
                hourMode = true;
            else if (doc.SelectSingleNode("settings/hourMode").InnerText == "true")
                hourMode = true;

            SettingsScreen.ColourTheme = doc.SelectSingleNode("settings/color").InnerText;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = null;

            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hourMode && hh == 12)                   // if time is equal to noon, do not subtract 12 hours but display PM
            {
                amPmOutput.Text = "PM";
                output24Hour.Text = "24 HOUR MODE: OFF";
            }
            else if (hourMode && hh > 12)               // subtract 12 if the time is over noon, display PM
            {
                hh -= 12;
                amPmOutput.Text = "PM";
                output24Hour.Text = "24 HOUR MODE: OFF";
            }
            else if (hourMode && hh <= 11)          //display AM if less than noon
            {
                amPmOutput.Text = "AM";
                output24Hour.Text = "24 HOUR MODE: OFF";
            }
            else if (hourMode == false)             //do not display anything if earlier than noon
            {
                amPmOutput.Text = null;
                output24Hour.Text = "24 HOUR MODE: ON";
            }
            if (hh < 10)                        //displays zeros before each instance of numbers as a place value for double digits
                time += "0" + hh;
            else
                time += hh;
            time += ":";
            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            time += ":";
            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;
            clockLabel.Text = time;

            #region COLOUR_CHANGES
            if (SettingsScreen.ColourTheme == "RED")
                ForeColor = Color.Red;
            else if (SettingsScreen.ColourTheme == "BLUE")
                ForeColor = Color.LightBlue;
            else if (SettingsScreen.ColourTheme == "YELLOW")
                ForeColor = Color.Yellow;
            else if (SettingsScreen.ColourTheme == "GREEN")
                ForeColor = Color.LimeGreen;
            else if (SettingsScreen.ColourTheme == "PURPLE")
                ForeColor = Color.Magenta;
            else if (SettingsScreen.ColourTheme == "DEFAULT")
                ForeColor = Color.White;
            #endregion //clock colour changes 

            //centres the clock at all times
            Point labelLocation = new Point((this.Width / 2) - clockLabel.Width / 2, (this.Height / 2) - clockLabel.Height / 2);
            clockLabel.Location = labelLocation; 
        }

        private void backButton_Click(object sender, EventArgs e)       //close this screen, stop timer, and open home screen
        {
            clockTimer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

        private void settingsButton_Click(object sender, EventArgs e)   //close current screen, and open settings
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SettingsScreen ss = new SettingsScreen();
            f.Controls.Add(ss);
        }
    }
}

