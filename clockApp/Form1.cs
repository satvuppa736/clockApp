///Satvir Uppal
///June 21 2018
///Clock App with an easy to use UI along with a hexidecimal clock and a stop watch function
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

    }
}
