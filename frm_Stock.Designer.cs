namespace GGMSYS
{
    partial class frm_Stock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_StockCode = new System.Windows.Forms.TextBox();
            this.text_StockID = new System.Windows.Forms.TextBox();
            this.text_StockName = new System.Windows.Forms.TextBox();
            this.text_StockSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.text_StockPrice = new System.Windows.Forms.TextBox();
            this.text_Stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_StockList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_StockList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.text_StockCode);
            this.groupBox1.Controls.Add(this.text_StockID);
            this.groupBox1.Controls.Add(this.text_StockName);
            this.groupBox1.Controls.Add(this.text_StockSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.text_StockPrice);
            this.groupBox1.Controls.Add(this.text_Stock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Detayları";
            // 
            // text_StockCode
            // 
            this.text_StockCode.Location = new System.Drawing.Point(107, 35);
            this.text_StockCode.Name = "text_StockCode";
            this.text_StockCode.ReadOnly = true;
            this.text_StockCode.Size = new System.Drawing.Size(176, 22);
            this.text_StockCode.TabIndex = 9;
            // 
            // text_StockID
            // 
            this.text_StockID.Location = new System.Drawing.Point(207, 35);
            this.text_StockID.Name = "text_StockID";
            this.text_StockID.ReadOnly = true;
            this.text_StockID.Size = new System.Drawing.Size(34, 22);
            this.text_StockID.TabIndex = 11;
            // 
            // text_StockName
            // 
            this.text_StockName.Location = new System.Drawing.Point(450, 32);
            this.text_StockName.Name = "text_StockName";
            this.text_StockName.Size = new System.Drawing.Size(176, 22);
            this.text_StockName.TabIndex = 0;
            // 
            // text_StockSearch
            // 
            this.text_StockSearch.Location = new System.Drawing.Point(107, 120);
            this.text_StockSearch.Name = "text_StockSearch";
            this.text_StockSearch.Size = new System.Drawing.Size(519, 22);
            this.text_StockSearch.TabIndex = 5;
            this.text_StockSearch.TextChanged += new System.EventHandler(this.text_StockSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ara:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::GGMSYS.Properties.Resources.icons8_delete_30;
            this.btn_Delete.Location = new System.Drawing.Point(652, 78);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(137, 60);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Image = global::GGMSYS.Properties.Resources.icons8_save_30;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Save.Location = new System.Drawing.Point(652, 10);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(137, 62);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Kaydet Güncelle";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // text_StockPrice
            // 
            this.text_StockPrice.Location = new System.Drawing.Point(450, 81);
            this.text_StockPrice.Name = "text_StockPrice";
            this.text_StockPrice.Size = new System.Drawing.Size(176, 22);
            this.text_StockPrice.TabIndex = 2;
            // 
            // text_Stock
            // 
            this.text_Stock.Location = new System.Drawing.Point(107, 78);
            this.text_Stock.Name = "text_Stock";
            this.text_Stock.Size = new System.Drawing.Size(176, 22);
            this.text_Stock.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok İsmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.data_StockList);
            this.groupBox2.Location = new System.Drawing.Point(1, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün ve Stok Listesi";
            // 
            // data_StockList
            // 
            this.data_StockList.AllowUserToAddRows = false;
            this.data_StockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_StockList.Location = new System.Drawing.Point(6, 21);
            this.data_StockList.Name = "data_StockList";
            this.data_StockList.ReadOnly = true;
            this.data_StockList.RowHeadersWidth = 51;
            this.data_StockList.RowTemplate.Height = 24;
            this.data_StockList.Size = new System.Drawing.Size(792, 458);
            this.data_StockList.TabIndex = 0;
            this.data_StockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_StockList_CellDoubleClick);
            // 
            // frm_Stock
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_Stock";
            this.Text = "Ürün Kayıt ve Stok Bilgisi";
            this.Load += new System.EventHandler(this.frm_Stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_StockList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_StockPrice;
        private System.Windows.Forms.TextBox text_Stock;
        private System.Windows.Forms.TextBox text_StockCode;
        private System.Windows.Forms.TextBox text_StockSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data_StockList;
        private System.Windows.Forms.TextBox text_StockName;
        private System.Windows.Forms.TextBox text_StockID;
    }
}