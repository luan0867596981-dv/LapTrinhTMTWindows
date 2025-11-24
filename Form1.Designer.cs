namespace BT03_Listview
{
    partial class frm_listview
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ly",
            "Thi Bong",
            "23456"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyen",
            "Van Chinh",
            "4555"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Luan",
            "Nguyen Minh",
            "12345"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.clnlastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnfirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.Label();
            this.txtlastnamee = new System.Windows.Forms.TextBox();
            this.txtfirstnamee = new System.Windows.Forms.TextBox();
            this.txtphonee = new System.Windows.Forms.TextBox();
            this.btnaddname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnlastname,
            this.clnfirstname,
            this.clnphone});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(25, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 348);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clnlastname
            // 
            this.clnlastname.Text = "Last Name";
            this.clnlastname.Width = 100;
            // 
            // clnfirstname
            // 
            this.clnfirstname.Text = "First Name";
            this.clnfirstname.Width = 120;
            // 
            // clnphone
            // 
            this.clnphone.Text = "Phone";
            this.clnphone.Width = 120;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(521, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Last Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.AutoSize = true;
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(522, 173);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(102, 20);
            this.txtfirstname.TabIndex = 2;
            this.txtfirstname.Text = "First Name";
            // 
            // txtphone
            // 
            this.txtphone.AutoSize = true;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(522, 273);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(61, 20);
            this.txtphone.TabIndex = 3;
            this.txtphone.Text = "Phone";
            // 
            // txtlastnamee
            // 
            this.txtlastnamee.Location = new System.Drawing.Point(525, 96);
            this.txtlastnamee.Name = "txtlastnamee";
            this.txtlastnamee.Size = new System.Drawing.Size(263, 22);
            this.txtlastnamee.TabIndex = 4;
            // 
            // txtfirstnamee
            // 
            this.txtfirstnamee.Location = new System.Drawing.Point(525, 196);
            this.txtfirstnamee.Name = "txtfirstnamee";
            this.txtfirstnamee.Size = new System.Drawing.Size(263, 22);
            this.txtfirstnamee.TabIndex = 5;
            // 
            // txtphonee
            // 
            this.txtphonee.Location = new System.Drawing.Point(525, 296);
            this.txtphonee.Name = "txtphonee";
            this.txtphonee.Size = new System.Drawing.Size(263, 22);
            this.txtphonee.TabIndex = 6;
            // 
            // btnaddname
            // 
            this.btnaddname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddname.Location = new System.Drawing.Point(670, 392);
            this.btnaddname.Name = "btnaddname";
            this.btnaddname.Size = new System.Drawing.Size(118, 29);
            this.btnaddname.TabIndex = 7;
            this.btnaddname.Text = "Add Name";
            this.btnaddname.UseVisualStyleBackColor = true;
            this.btnaddname.Click += new System.EventHandler(this.btnaddname_Click);
            // 
            // frm_listview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddname);
            this.Controls.Add(this.txtphonee);
            this.Controls.Add(this.txtfirstnamee);
            this.Controls.Add(this.txtlastnamee);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.listView1);
            this.Name = "frm_listview";
            this.Text = "ListView Demo";
            this.Load += new System.EventHandler(this.frm_listview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clnlastname;
        private System.Windows.Forms.ColumnHeader clnfirstname;
        private System.Windows.Forms.ColumnHeader clnphone;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.Label txtfirstname;
        private System.Windows.Forms.Label txtphone;
        private System.Windows.Forms.TextBox txtlastnamee;
        private System.Windows.Forms.TextBox txtfirstnamee;
        private System.Windows.Forms.TextBox txtphonee;
        private System.Windows.Forms.Button btnaddname;
    }
}

