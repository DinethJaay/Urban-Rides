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
    public partial class vehicalD : Form
    {
        public vehicalD()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "insert into v_service( vehical_type,full_service,body_wash,interior_cleaning,wax_polish,engine_oil,coolent,gear_oil,air_filter,oil_filter,air_freshner)" +
                    "values('" + cmbvehicaltype.Text + "','" + txtfullservice.Text + "','" + txtbodywash.Text + "','" + txtinterior.Text + "','" + txtwax.Text + "','" + txtengine.Text + "','" + txtcoolent.Text + "','" + txtgear.Text + "','" + txtairfilter.Text + "','" + txtoilfilter.Text + "','" + txtairfreshner.Text + "')";

                SqlCommand command = new SqlCommand(sql, ob);
                command.ExecuteNonQuery();
                ob.Close();
                MessageBox.Show("Successful !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select * from v_service";

                SqlCommand command = new SqlCommand(sql, ob);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                ob.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int vehicalrowview;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicalrowview = e.RowIndex;
            DataGridViewRow row=dataGridView1.Rows[vehicalrowview];
            cmbvehicaltype.Text= row.Cells[0].Value.ToString();
            txtfullservice.Text= row.Cells[1].Value.ToString();
            txtbodywash.Text= row.Cells[2].Value.ToString();
            txtinterior.Text= row.Cells[3].Value.ToString();
            txtwax.Text= row.Cells[4].Value.ToString();
            txtengine.Text= row.Cells[5].Value.ToString();
            txtcoolent.Text= row.Cells[6].Value.ToString();
            txtgear.Text= row.Cells[7].Value.ToString();
            txtairfilter.Text= row.Cells[8].Value.ToString();
            txtoilfilter.Text=row.Cells[9].Value.ToString();
            txtairfreshner.Text= row.Cells[10].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "update v_service set full_service='" + txtfullservice.Text + "',body_wash='" + txtbodywash.Text + "',interior_cleaning='" + txtinterior.Text + "',wax_polish='" + txtwax.Text + "',engine_oil='" + txtengine.Text + "',coolent='" + txtcoolent.Text + "',gear_oil='" + txtgear.Text + "',air_filter='" + txtairfilter.Text + "',oil_filter ='" + txtoilfilter.Text + "',air_freshner ='" + txtairfreshner.Text + "' where vehical_type='" + cmbvehicaltype.Text + "'";

                SqlCommand command = new SqlCommand(sql, ob);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                ob.Close();

                MessageBox.Show("Please Press View Button after updating details !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbvehicaltype.Text = "";
            txtfullservice.Text = "";
            txtbodywash.Text = "";
            txtinterior.Text = "";
            txtwax.Text = "";
            txtengine.Text = "";
            txtcoolent.Text = "";
            txtgear.Text = "";
            txtairfilter.Text = "";
            txtoilfilter.Text = "";
            txtairfreshner.Text = "";
        }

        private void txthome_Click(object sender, EventArgs e)
        {
            Select_Service ob=new Select_Service();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void txtengine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
