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
using Microsoft.Reporting.WinForms;

namespace Urban_Rides
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource cus = new ReportDataSource("Customer", customer());
            ReportDataSource vehi = new ReportDataSource("Vehicle", vehical());
            ReportDataSource bil = new ReportDataSource("Bill", bill());
            ReportDataSource vs = new ReportDataSource("Vehicle_service", v_service());
            ReportDataSource cs = new ReportDataSource("Customer_Service", c_service());

           
            reportViewer1.LocalReport.DataSources.Add(cus);
            reportViewer1.LocalReport.DataSources.Add(vehi);
            reportViewer1.LocalReport.DataSources.Add(bil);
            reportViewer1.LocalReport.DataSources.Add(vs);
            reportViewer1.LocalReport.DataSources.Add(cs);
            reportViewer1.RefreshReport();



        }
        private DataTable customer()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=urban_rides;User ID=Dinethjay;Password=abcd");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer",con);
            SqlDataReader rd=cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable vehical()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=urban_rides;User ID=Dinethjay;Password=abcd");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from vehical", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable bill()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=urban_rides;User ID=Dinethjay;Password=abcd");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bill", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable v_service()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=urban_rides;User ID=Dinethjay;Password=abcd");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from v_service", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable c_service()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=urban_rides;User ID=Dinethjay;Password=abcd");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from c_service", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select_Service ob1 = new Select_Service();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }
    }
}
