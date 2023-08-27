namespace Urban_Rides
{
    partial class Insert_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Details));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblvehiclenum = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblphonenum = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.txtcustomernic = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttp = new System.Windows.Forms.TextBox();
            this.txtvehicalnumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.brnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnbill = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnselectprice = new System.Windows.Forms.Button();
            this.lblshowprice = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1072, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vehicleDetailsToolStripMenuItem
            // 
            this.vehicleDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDetailsToolStripMenuItem,
            this.vehicleDetailsToolStripMenuItem1});
            this.vehicleDetailsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vehicleDetailsToolStripMenuItem.Name = "vehicleDetailsToolStripMenuItem";
            this.vehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(86, 31);
            this.vehicleDetailsToolStripMenuItem.Text = "Details";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // vehicleDetailsToolStripMenuItem1
            // 
            this.vehicleDetailsToolStripMenuItem1.Name = "vehicleDetailsToolStripMenuItem1";
            this.vehicleDetailsToolStripMenuItem1.Size = new System.Drawing.Size(251, 32);
            this.vehicleDetailsToolStripMenuItem1.Text = "Vehicle Details";
            this.vehicleDetailsToolStripMenuItem1.Click += new System.EventHandler(this.vehicleDetailsToolStripMenuItem1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.ForeColor = System.Drawing.Color.LightGray;
            this.lblid.Location = new System.Drawing.Point(112, 94);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 16);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Customer ID";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.BackColor = System.Drawing.Color.Transparent;
            this.lblnic.ForeColor = System.Drawing.Color.LightGray;
            this.lblnic.Location = new System.Drawing.Point(112, 141);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(101, 16);
            this.lblnic.TabIndex = 2;
            this.lblnic.Text = "Customer NIC";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.ForeColor = System.Drawing.Color.LightGray;
            this.lblname.Location = new System.Drawing.Point(112, 187);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 16);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.ForeColor = System.Drawing.Color.LightGray;
            this.lbladdress.Location = new System.Drawing.Point(112, 231);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(65, 16);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "Address";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.ForeColor = System.Drawing.Color.LightGray;
            this.lblemail.Location = new System.Drawing.Point(112, 274);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 16);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email";
            // 
            // lblvehiclenum
            // 
            this.lblvehiclenum.AutoSize = true;
            this.lblvehiclenum.BackColor = System.Drawing.Color.Transparent;
            this.lblvehiclenum.ForeColor = System.Drawing.Color.LightGray;
            this.lblvehiclenum.Location = new System.Drawing.Point(565, 94);
            this.lblvehiclenum.Name = "lblvehiclenum";
            this.lblvehiclenum.Size = new System.Drawing.Size(117, 16);
            this.lblvehiclenum.TabIndex = 6;
            this.lblvehiclenum.Text = "Vehicle Number";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.ForeColor = System.Drawing.Color.LightGray;
            this.lbldate.Location = new System.Drawing.Point(565, 140);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(40, 16);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.ForeColor = System.Drawing.Color.LightGray;
            this.lblprice.Location = new System.Drawing.Point(565, 183);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(43, 16);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Price";
            // 
            // lblphonenum
            // 
            this.lblphonenum.AutoSize = true;
            this.lblphonenum.BackColor = System.Drawing.Color.Transparent;
            this.lblphonenum.ForeColor = System.Drawing.Color.LightGray;
            this.lblphonenum.Location = new System.Drawing.Point(112, 317);
            this.lblphonenum.Name = "lblphonenum";
            this.lblphonenum.Size = new System.Drawing.Size(109, 16);
            this.lblphonenum.TabIndex = 9;
            this.lblphonenum.Text = "Phone Number";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(235, 88);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(248, 22);
            this.txtcustomerid.TabIndex = 10;
            this.txtcustomerid.TextChanged += new System.EventHandler(this.txtcustomerid_TextChanged);
            this.txtcustomerid.Validating += new System.ComponentModel.CancelEventHandler(this.txtcustomerid_Validating);
            // 
            // txtcustomernic
            // 
            this.txtcustomernic.Location = new System.Drawing.Point(235, 135);
            this.txtcustomernic.Name = "txtcustomernic";
            this.txtcustomernic.Size = new System.Drawing.Size(248, 22);
            this.txtcustomernic.TabIndex = 11;
            this.txtcustomernic.TextChanged += new System.EventHandler(this.txtcustomernic_TextChanged);
            this.txtcustomernic.Validating += new System.ComponentModel.CancelEventHandler(this.txtcustomernic_Validating);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(235, 181);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(248, 22);
            this.txtname.TabIndex = 12;
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(235, 228);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(248, 22);
            this.txtaddress.TabIndex = 13;
            this.txtaddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtaddress_Validating);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(235, 271);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(248, 22);
            this.txtemail.TabIndex = 14;
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(235, 317);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(248, 22);
            this.txttp.TabIndex = 18;
            this.txttp.Validating += new System.ComponentModel.CancelEventHandler(this.txttp_Validating);
            // 
            // txtvehicalnumber
            // 
            this.txtvehicalnumber.Location = new System.Drawing.Point(704, 88);
            this.txtvehicalnumber.Name = "txtvehicalnumber";
            this.txtvehicalnumber.Size = new System.Drawing.Size(248, 22);
            this.txtvehicalnumber.TabIndex = 15;
            this.txtvehicalnumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtvehicalnumber_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(704, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkGray;
            this.btnsave.Location = new System.Drawing.Point(765, 251);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 42);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // brnclear
            // 
            this.brnclear.BackColor = System.Drawing.Color.DarkGray;
            this.brnclear.ForeColor = System.Drawing.Color.Black;
            this.brnclear.Location = new System.Drawing.Point(345, 467);
            this.brnclear.Name = "brnclear";
            this.brnclear.Size = new System.Drawing.Size(109, 42);
            this.brnclear.TabIndex = 26;
            this.brnclear.Text = "Clear";
            this.brnclear.UseVisualStyleBackColor = false;
            this.brnclear.Click += new System.EventHandler(this.brnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkGray;
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(592, 467);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 42);
            this.btnexit.TabIndex = 27;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnbill
            // 
            this.btnbill.BackColor = System.Drawing.Color.DarkGray;
            this.btnbill.ForeColor = System.Drawing.Color.Black;
            this.btnbill.Location = new System.Drawing.Point(843, 467);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(109, 42);
            this.btnbill.TabIndex = 28;
            this.btnbill.Text = "Create Bill";
            this.btnbill.UseVisualStyleBackColor = false;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DarkGray;
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(115, 467);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(109, 42);
            this.btnback.TabIndex = 29;
            this.btnback.Text = "Home";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnselectprice
            // 
            this.btnselectprice.BackColor = System.Drawing.Color.DarkGray;
            this.btnselectprice.Location = new System.Drawing.Point(879, 178);
            this.btnselectprice.Name = "btnselectprice";
            this.btnselectprice.Size = new System.Drawing.Size(73, 42);
            this.btnselectprice.TabIndex = 30;
            this.btnselectprice.Text = "Select Price";
            this.btnselectprice.UseVisualStyleBackColor = false;
            this.btnselectprice.Click += new System.EventHandler(this.btnselectprice_Click);
            // 
            // lblshowprice
            // 
            this.lblshowprice.AutoSize = true;
            this.lblshowprice.BackColor = System.Drawing.Color.Transparent;
            this.lblshowprice.ForeColor = System.Drawing.Color.White;
            this.lblshowprice.Location = new System.Drawing.Point(741, 183);
            this.lblshowprice.Name = "lblshowprice";
            this.lblshowprice.Size = new System.Drawing.Size(0, 16);
            this.lblshowprice.TabIndex = 31;
            // 
            // Insert_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Urban_Rides.Properties.Resources.normal3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.lblshowprice);
            this.Controls.Add(this.btnselectprice);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnbill);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.brnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.txtvehicalnumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcustomernic);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.lblphonenum);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblvehiclenum);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblnic);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1090, 600);
            this.MinimumSize = new System.Drawing.Size(1090, 600);
            this.Name = "Insert_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert_Details";
            this.Load += new System.EventHandler(this.Insert_Details_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleDetailsToolStripMenuItem1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblvehiclenum;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblphonenum;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.TextBox txtcustomernic;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.TextBox txtvehicalnumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button brnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnselectprice;
        private System.Windows.Forms.Label lblshowprice;
    }
}