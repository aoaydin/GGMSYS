namespace GGMSYS
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Users = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_StokActivity = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_Users);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_Reports);
            this.panel1.Controls.Add(this.btn_StokActivity);
            this.panel1.Controls.Add(this.btn_Client);
            this.panel1.Controls.Add(this.btn_Stock);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 757);
            this.panel1.TabIndex = 0;
            // 
            // btn_Users
            // 
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Users.Image = ((System.Drawing.Image)(resources.GetObject("btn_Users.Image")));
            this.btn_Users.Location = new System.Drawing.Point(2, 641);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(204, 76);
            this.btn_Users.TabIndex = 5;
            this.btn_Users.Text = "Kullanıcılar";
            this.btn_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sales.Image")));
            this.btn_Sales.Location = new System.Drawing.Point(2, 359);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(204, 76);
            this.btn_Sales.TabIndex = 4;
            this.btn_Sales.Text = "Alış/Satışlarım";
            this.btn_Sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sales.UseVisualStyleBackColor = true;
            this.btn_Sales.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reports.Image")));
            this.btn_Reports.Location = new System.Drawing.Point(3, 547);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(203, 76);
            this.btn_Reports.TabIndex = 4;
            this.btn_Reports.Text = "Raporlarım";
            this.btn_Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_StokActivity
            // 
            this.btn_StokActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StokActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_StokActivity.Image = ((System.Drawing.Image)(resources.GetObject("btn_StokActivity.Image")));
            this.btn_StokActivity.Location = new System.Drawing.Point(3, 453);
            this.btn_StokActivity.Name = "btn_StokActivity";
            this.btn_StokActivity.Size = new System.Drawing.Size(203, 76);
            this.btn_StokActivity.TabIndex = 3;
            this.btn_StokActivity.Text = "Stok Hareketlerim";
            this.btn_StokActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_StokActivity.UseVisualStyleBackColor = true;
            this.btn_StokActivity.Click += new System.EventHandler(this.btn_StockActivity_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Client.Image = ((System.Drawing.Image)(resources.GetObject("btn_Client.Image")));
            this.btn_Client.Location = new System.Drawing.Point(3, 267);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(203, 76);
            this.btn_Client.TabIndex = 2;
            this.btn_Client.Text = "Firmalarım";
            this.btn_Client.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Stock.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stock.Image")));
            this.btn_Stock.Location = new System.Drawing.Point(3, 174);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(203, 76);
            this.btn_Stock.TabIndex = 1;
            this.btn_Stock.Text = "Ürün ve Stoklarım";
            this.btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stock.UseVisualStyleBackColor = true;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 755);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "GGMSYS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StokActivity;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Sales;
    }
}