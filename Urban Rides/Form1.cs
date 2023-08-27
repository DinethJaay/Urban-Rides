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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
                if ((txtusername.Text == "urban") && (txtpassword.Text =="1234"))
                {
                    Select_Service ob1 = new Select_Service();
                    this.Hide();
                    ob1.ShowDialog();
                    ob1.MdiParent = this;
                }
                else
                {
                MetroFramework.MetroMessageBox.Show(this,"\t \tLogin Faild ! \n Please Enter Valid User Name Or Password !");
                txtpassword.Text = "";
                txtusername.Text = "";
                }
            
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            if(txtusername.Text=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtusername, "Enter Valid User Name");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtusername, "");
            }
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtpassword.Text=="")
            {
                e.Cancel = true;
                errorProvider2.SetError(txtpassword, "Enter Valid Password");
            }
            else
            {
                e.Cancel= false;
                errorProvider2.SetError(txtpassword, "");
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text=="User Name")
            {
                txtusername.Text = "";
                txtusername.ForeColor=Color.Black;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "User Name";
                txtusername.ForeColor = Color.Silver;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.Silver;
            }
        }
    }
}
