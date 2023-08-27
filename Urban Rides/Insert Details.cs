using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Urban_Rides
{
    public partial class Insert_Details : Form
    {
        public Insert_Details()
        {
            InitializeComponent();
        }

        private void vehicleDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vehicle_Details ob1 = new Vehicle_Details();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Details ob1 = new Customer_Details();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            Bill ob = new Bill();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();
                string sql = "insert into customer(customer_id,customer_nic,c_name,c_address,email,tp,date,price,vehicle_number)" +
                    " values ('" + txtcustomerid.Text + "','" + txtcustomernic.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txttp.Text + "','" + dateTimePicker1.Value.Date + "','" + lblshowprice.Text + "','" + txtvehicalnumber.Text + "')";

                SqlCommand command = new SqlCommand(sql, ob);
                command.ExecuteNonQuery();
                ob.Close();
                MetroFramework.MetroMessageBox.Show(this,"Successful !");

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }



        }

        private void btnselectprice_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtcustomernic.Text != "")&&(txtcustomerid.Text !="")&&(txtname.Text !="")&&(txtaddress.Text !="")&&(txtemail.Text != "")&&(txttp.Text !=""))
                {
                    string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                    SqlConnection ob = new SqlConnection(connectionstring);
                    ob.Open();

                    string sql = "Select price From vehical where vehicle_number='" + txtvehicalnumber.Text + "'";

                    SqlCommand command = new SqlCommand(sql, ob);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {

                        lblshowprice.Text = dr.GetValue(0).ToString() + (".00");
                    }

                    ob.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Eneter Details !");
                }
                
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Select_Service ob = new Select_Service();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void brnclear_Click(object sender, EventArgs e)
        {
            txtcustomerid.Text = "";
            txtcustomernic.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txttp.Text = "";
            txtaddress.Text = "";
            txtvehicalnumber.Text = "";
            lblshowprice.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomernic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomerid_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtcustomernic_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtaddress_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txttp_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtvehicalnumber_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Insert_Details_Load(object sender, EventArgs e)
        {
        }
    }
}
