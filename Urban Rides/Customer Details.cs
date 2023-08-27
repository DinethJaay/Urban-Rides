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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtenternic.Text != "")
                {
                    string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                    SqlConnection ob = new SqlConnection(connectionstring);
                    ob.Open();

                    string sql = "select * from customer where customer_nic='" + txtenternic.Text + "'";

                    SqlCommand command = new SqlCommand(sql, ob);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    ob.Close();
                }
                else
                {

                    MetroFramework.MetroMessageBox.Show(this,"Please Enter NIC Number !");
                }
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        int customerrowview;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerrowview = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[customerrowview];
            txtcusid.Text = row.Cells[0].Value.ToString();
           txtcusnic.Text = row.Cells[1].Value.ToString();
            txtcusname.Text = row.Cells[2].Value.ToString();
            txtcusaddress.Text = row.Cells[3].Value.ToString();
            txtcusemail.Text = row.Cells[4].Value.ToString();
            txtcusphone.Text = row.Cells[5].Value.ToString();
           
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();
                string sql = "select * from customer";

                SqlCommand command = new SqlCommand(sql, ob);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "delete from customer where customer_id='" + txtcusid.Text + "'";

                SqlCommand command = new SqlCommand(sql, ob);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable=new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource=dataTable;

                ob.Close();

                MetroFramework.MetroMessageBox.Show(this,"Please press View button after deleting the details !");
                
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql= "update customer set customer_nic='" + txtcusnic.Text+ "',c_name='"+txtcusname.Text+ "',c_address='"+txtcusaddress.Text+ "',email='"+txtcusemail.Text+ "',tp='"+txtcusphone.Text+ "' where customer_id='"+txtcusid.Text+"'";

                SqlCommand command=new SqlCommand(sql, ob);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable= new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource =dataTable;

                ob.Close();

                MetroFramework.MetroMessageBox.Show(this,"Please Press View Button after updating details !");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcusid.Text = "";
            txtcusnic.Text = "";
            txtcusname.Text = "";
            txtcusaddress.Text = "";
            txtcusemail.Text = "";
            txtcusphone.Text = "";
            txtenternic.Text = "";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Insert_Details ob=new Insert_Details();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }
    }
}
