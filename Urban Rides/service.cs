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
    public partial class service : Form
    {
        public service()
        {
            InitializeComponent();
            txtcoolent.Text = "0";
            txtgear.Text = "0";
            txtengine.Text = "0";
            txtairfreshner.Text = "0";
            cmbvtype.SelectedIndex = 0;

        }

        private void vehicalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicalD ob=new vehicalD();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }
        double fullService = 0,bodyWash=0,interior=0,wax=0,airfilter=0,oilfilter=0,coolent=0,gear=0,engine=0,airfreshner=0;

        private void rdoengine_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select engine_oil from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        engine = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdoairfreshner_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select air_freshner from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        airfreshner = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdogear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select gear_oil from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        gear = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void rdocoolent_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select coolent from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        coolent = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "insert into c_service(c_id,c_nic,c_name,c_address,c_tp,vehical_type,v_number,total)" +
                    "values('" + txtcid.Text + "','" + txtcnic.Text + "','" + txtcname.Text + "','" + txtcaddress.Text + "','" + txttp.Text + "','" + cmbvtype.Text + "','" + txtvnumber.Text + "','" + lblprice.Text + "')";

                SqlCommand command = new SqlCommand(sql, ob);
                command.ExecuteNonQuery();
                ob.Close();
                MetroFramework.MetroMessageBox.Show(this,"successfuly insertted");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fullService = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bodyWash = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            interior=0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            wax = 0;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            airfilter = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            oilfilter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcid.Text = "";
            txtcnic.Text = "";
            txtcname.Text = "";
            txtcaddress.Text = "";
            txttp.Text = "";
            cmbvtype.SelectedIndex = 0;
            txtvnumber.Text = "";
            txtcoolent.Text = "0";
            txtgear.Text = "0";
            txtengine.Text = "0";
            txtairfreshner.Text = "0";
            lblprice.Text = "";
            
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Select_Service ob = new Select_Service();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerD ob=new customerD();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void rdooilfilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select oil_filter from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        oilfilter = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdoairfilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select air_filter from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        airfilter = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdowax_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select wax_polish from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        wax = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdointerior_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select interior_cleaning from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        interior = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdobodywash_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select body_wash from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        bodyWash = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void rdofullservice_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select full_service from v_service where vehical_type='" + cmbvtype.Text + "'";
                SqlCommand command = new SqlCommand(sql, ob);

                SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        fullService = reader.GetDouble(0);
                        reader.Close();

                    }
                }

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        int qcoolent = 0, qgear = 0, qengine = 0, qairfreshner = 0;
        double total;
        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtcid.Text != "") && (txtcnic.Text != "") && (txtcname.Text != "") && (txtcaddress.Text != "") && (txttp.Text != "") && (txtvnumber.Text != ""))
                    {
                    qcoolent = Convert.ToInt32(txtcoolent.Text);
                    qgear = Convert.ToInt32(txtgear.Text);
                    qengine = Convert.ToInt32(txtengine.Text);
                    qairfreshner = Convert.ToInt32(txtairfreshner.Text);

                    total = fullService + bodyWash + interior + wax + airfilter + oilfilter + (coolent * qcoolent) + (gear * qgear) + (engine * qengine) + (airfreshner * qairfreshner);

                    lblprice.Text = total.ToString() + ".00";
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter Details !");
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
