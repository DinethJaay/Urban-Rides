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
    public partial class Vehicle_Details : Form
    {
        public Vehicle_Details()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try 
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();
                string sql = "insert into vehical(vehicle_number,engine_number,chassis_number,price,v_type,v_brand,v_model)" +
                    "values('" + txtvnumber.Text + "','" + txtenumber.Text + "','" + txtcnumber.Text + "','" + txtprice.Text + "','" + cmbtype.Text + "','" + cmbbrand.Text + "','" + cmbtype.Text + "')";
                SqlCommand command=new SqlCommand(sql,ob);
                command.ExecuteNonQuery();
                ob.Close();
                MetroFramework.MetroMessageBox.Show(this, "Successful !");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();
                string sql = "select * from vehical";

                SqlCommand command= new SqlCommand(sql,ob);
                SqlDataAdapter adapter= new SqlDataAdapter(command);
                DataTable dataTable=new DataTable();
               adapter.Fill(dataTable);
                dataGridView1.DataSource=dataTable;
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        int vehiclenumrow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vehiclenumrow=e.RowIndex;
            DataGridViewRow row=dataGridView1.Rows[vehiclenumrow];
            txtvnumber.Text=row.Cells[0].Value.ToString();
            txtenumber.Text=row.Cells[1].Value.ToString();
            txtcnumber.Text=row.Cells[2].Value.ToString();
            txtprice.Text=row.Cells[3].Value.ToString();
            cmbtype.Text=row.Cells[4].Value.ToString();
            cmbbrand.Text=row.Cells[5].Value.ToString();
            cmbmodel.Text=row.Cells[6].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
              
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "Update vehical set engine_number='"+txtenumber.Text+"',chassis_number='"+txtcnumber.Text+"',price='"+txtprice.Text+ "' where vehicle_number='"+txtvnumber.Text+"'";

                SqlCommand command=new SqlCommand(sql, ob);
                command.ExecuteNonQuery();

                ob.Close();

                MetroFramework.MetroMessageBox.Show(this, "Successful !");
                MetroFramework.MetroMessageBox.Show(this, "Please click view button to cheak updated Informations !");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);          
            }
        }

        private void btbdelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "Delete from vehical where vehicle_number='" + txtvnumber.Text + "'";

                SqlCommand command=new SqlCommand(sql, ob);
                command.ExecuteNonQuery ();

                ob.Close();

                MetroFramework.MetroMessageBox.Show(this, "Successful !");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtvnumber.Text = "";
            txtenumber.Text = "";
            txtcnumber.Text = "";
            txtprice.Text = "";
            cmbbrand.Text = "";
            cmbmodel.Text = "";
            cmbtype.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
             Insert_Details ob1=new Insert_Details();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent= this;
        }
    }
}
