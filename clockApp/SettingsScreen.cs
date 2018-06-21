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
    public partial class SettingsScreen : UserControl
    {
        public static string ColourTheme = "DEFAULT";
        public SettingsScreen()
        {
            InitializeComponent();
            if (ClockScreen.hourMode == false)
            {
                offBtn.Checked = false;
                onBtn.Checked = true;
            }
            else if (ClockScreen.hourMode)
            {
                onBtn.Checked = false;
                offBtn.Checked = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ClockScreen cs = new ClockScreen();
            f.Controls.Add(cs);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region COLOURS_CHANGING
            if (colourSelecter.SelectedItem == "RED")
            {
                ColourTheme = "RED";
            }
            else if (colourSelecter.SelectedItem == "BLUE")
            {
                ColourTheme = "BLUE";
            }
            else if (colourSelecter.SelectedItem == "YELLOW")
            {
                ColourTheme = "YELLOW";
            }
            else if (colourSelecter.SelectedItem == "GREEN")
            {
                ColourTheme = "GREEN";
            }
            else if (colourSelecter.SelectedItem == "PURPLE")
            {
                ColourTheme = "PURPLE";
            }
            else if (colourSelecter.SelectedItem == "DEFAULT")
            {
                ColourTheme = "WHITE";
            }
            #endregion

            if (onBtn.Checked)
                ClockScreen.hourMode = false;
            else if (offBtn.Checked)
                ClockScreen.hourMode = true;

            XmlWriter writer = XmlWriter.Create("Settings.xml");

            //Write the root element 
            writer.WriteStartElement("settings");

            //Write sub-elements 
            writer.WriteElementString("color", ColourTheme);
            writer.WriteElementString("hourMode", Convert.ToString(ClockScreen.hourMode));


            // end the element 
            writer.WriteEndElement();

            //Write the XML to file and close the writer 
            writer.Close();
        }
    }
}
