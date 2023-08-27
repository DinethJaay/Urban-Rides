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
    public partial class customerD : Form
    {
        public customerD()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select * from c_service";

                SqlCommand command = new SqlCommand(sql, ob);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Select_Service ob = new Select_Service();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }
    }
}
