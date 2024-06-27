namespace GGMSYS
{
    partial class frm_Reports
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
            this.btn_StockList = new System.Windows.Forms.Button();
            this.btn_ClientList = new System.Windows.Forms.Button();
            this.btn_StockStatus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_StockList
            // 
            this.btn_StockList.Location = new System.Drawing.Point(12, 141);
            this.btn_StockList.Name = "btn_StockList";
            this.btn_StockList.Size = new System.Drawing.Size(98, 81);
            this.btn_StockList.TabIndex = 0;
            this.btn_StockList.Text = "Ürün Listesi";
            this.btn_StockList.UseVisualStyleBackColor = true;
            this.btn_StockList.Click += new System.EventHandler(this.btn_StockList_Click);
            // 
            // btn_ClientList
            // 
            this.btn_ClientList.Location = new System.Drawing.Point(131, 141);
            this.btn_ClientList.Name = "btn_ClientList";
            this.btn_ClientList.Size = new System.Drawing.Size(98, 81);
            this.btn_ClientList.TabIndex = 1;
            this.btn_ClientList.Text = "Firma Listesi";
            this.btn_ClientList.UseVisualStyleBackColor = true;
            this.btn_ClientList.Click += new System.EventHandler(this.btn_ClientList_Click);
            // 
            // btn_StockStatus
            // 
            this.btn_StockStatus.Location = new System.Drawing.Point(257, 141);
            this.btn_StockStatus.Name = "btn_StockStatus";
            this.btn_StockStatus.Size = new System.Drawing.Size(98, 81);
            this.btn_StockStatus.TabIndex = 2;
            this.btn_StockStatus.Text = "Güncel Stok Durumu";
            this.btn_StockStatus.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "İki Tarih Arası Stok Durumu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Location = new System.Drawing.Point(152, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Value = new System.DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 349);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_StockStatus);
            this.Controls.Add(this.btn_ClientList);
            this.Controls.Add(this.btn_StockList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_Reports";
            this.Text = "Raporlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StockList;
        private System.Windows.Forms.Button btn_ClientList;
        private System.Windows.Forms.Button btn_StockStatus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}