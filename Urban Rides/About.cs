using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Rides
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Select_Service ob1 = new Select_Service();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }
    }
}
