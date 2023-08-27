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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtrec.Text != "") && (txtkm.Text != "")&&(txtbillcusid.Text != ""))
                {
                    string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                    SqlConnection ob = new SqlConnection(connectionstring);
                    ob.Open();

                    string sql = "Select vehicle_number,date From customer where customer_id='" + txtbillcusid.Text + "'";

                    SqlCommand command = new SqlCommand(sql, ob);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        lblvnumber.Text = dr.GetValue(0).ToString();
                        dateTimePicker2.Text = dr.GetValue(1).ToString();

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
            Insert_Details ob=new Insert_Details();
            this.Hide();
            ob.ShowDialog();
            ob.MdiParent = this;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Select_Service ob1=new Select_Service();
            this.Hide();
            ob1.ShowDialog();
            ob1.MdiParent = this;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                double onedayamont,amount,km,kmperday,days,extrakmprice=0,discountedamount=0,finalamount=0;
                
                

                string connectionstring = @"data source=MSI\SQLEXPRESS ;initial catalog=urban_rides;user id=Dinethjay;password=abcd ";
                SqlConnection ob = new SqlConnection(connectionstring);
                ob.Open();

                string sql = "select price from customer where customer_id='" + txtbillcusid.Text + "' ";
                SqlCommand command = new SqlCommand(sql, ob);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                   lblonedayamount.Text = dr.GetValue(0).ToString()+(".00");
                }

                ob.Close();

                days = ((TimeSpan)(dateTimePicker1.Value.Date-dateTimePicker2.Value.Date)).Days;
                lblrdate.Text = days.ToString();
                onedayamont = Convert.ToDouble(lblonedayamount.Text);
                km=Convert.ToDouble(txtkm.Text);

                kmperday = days * 100;
                if(kmperday<km)
                {
                    extrakmprice=(km - kmperday)*30;
                }
                amount = (days * onedayamont) + extrakmprice;
                lblamountdisplay.Text = amount.ToString()+(".00");


                if(amount>=20000)
                {
                    discountedamount = (amount * 10) / 100;
                }
                else if(amount>=15000)
                {
                    discountedamount= (amount * 7) /100;
                }
                else if(amount>=10000)
                {
                    discountedamount=(amount * 5) /100;
                }
                else
                {
                    discountedamount = 0;
                }

                lbldiscountedamountdisplay.Text = discountedamount.ToString()+(".00");

                finalamount = amount - discountedamount;
                lbltotalamountdisplay.Text = finalamount.ToString() + (".00");

            }
            catch(Exception ex)
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

                string sql = "insert into bill(receipt_number,customer_id,out_date,KM,vehicle_number,rent_days,amount,D_amount,total)" +
                    "values('" + txtrec.Text + "','" + txtbillcusid.Text + "','" + dateTimePicker1.Value.Date+ "','" + txtkm.Text + "','" + lblvnumber.Text + "','" + lblrdate.Text + "','"+lblamountdisplay.Text+"','" + lbldiscountedamountdisplay.Text + "','" + lbltotalamountdisplay.Text + "')";

                SqlCommand command=new SqlCommand(sql, ob);
                command.ExecuteNonQuery();

                ob.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
                
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbillcusid.Text = "";
            txtkm.Text = "";
            txtrec.Text = "";
            lblvnumber.Text = "";
            lblonedayamount.Text = "";
            lblrdate.Text = "";
            lblamountdisplay.Text = "";
            lbldiscountedamountdisplay.Text = "";
            lbltotalamountdisplay.Text = "";
            

            
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
