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
    public partial class Select_Service : Form
    {
        public Select_Service()
        {
            InitializeComponent();
        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            Insert_Details ob1=new Insert_Details();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }

        private void btnservice_Click(object sender, EventArgs e)
        {
            service ob=new service();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void Select_Service_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports ob = new reports();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }
        bool sidebarExpand;
        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width +=10;
                if(sidebar.Width==sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           About ob1 = new About();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            help ob = new help();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }
    }
}
