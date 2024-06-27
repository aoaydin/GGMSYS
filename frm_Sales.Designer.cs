namespace GGMSYS
{
    partial class frm_Sales
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
            this.label9 = new System.Windows.Forms.Label();
            this.numeric_Sira = new System.Windows.Forms.NumericUpDown();
            this.text_StockStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sıra = new System.Windows.Forms.Label();
            this.text_Seri = new System.Windows.Forms.TextBox();
            this.Seri = new System.Windows.Forms.Label();
            this.text_CompanyCode = new System.Windows.Forms.TextBox();
            this.combo_StockName = new System.Windows.Forms.ComboBox();
            this.combo_CompanyName = new System.Windows.Forms.ComboBox();
            this.btn_AddSaleList = new System.Windows.Forms.Button();
            this.check_Input = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.text_StockPrice = new System.Windows.Forms.TextBox();
            this.text_SalesAmount = new System.Windows.Forms.TextBox();
            this.text_StockCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_SaleList = new System.Windows.Forms.DataGridView();
            this.IsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evrak_Seri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evrak_Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sira)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_SaleList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numeric_Sira);
            this.groupBox1.Controls.Add(this.text_StockStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Sıra);
            this.groupBox1.Controls.Add(this.text_Seri);
            this.groupBox1.Controls.Add(this.Seri);
            this.groupBox1.Controls.Add(this.text_CompanyCode);
            this.groupBox1.Controls.Add(this.combo_StockName);
            this.groupBox1.Controls.Add(this.combo_CompanyName);
            this.groupBox1.Controls.Add(this.btn_AddSaleList);
            this.groupBox1.Controls.Add(this.check_Input);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_Search);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.text_StockPrice);
            this.groupBox1.Controls.Add(this.text_SalesAmount);
            this.groupBox1.Controls.Add(this.text_StockCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Ürün Detayları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "KG";
            // 
            // numeric_Sira
            // 
            this.numeric_Sira.Location = new System.Drawing.Point(450, 27);
            this.numeric_Sira.Name = "numeric_Sira";
            this.numeric_Sira.Size = new System.Drawing.Size(176, 22);
            this.numeric_Sira.TabIndex = 26;
            this.numeric_Sira.ValueChanged += new System.EventHandler(this.numeric_Sira_ValueChanged);
            // 
            // text_StockStatus
            // 
            this.text_StockStatus.Location = new System.Drawing.Point(450, 139);
            this.text_StockStatus.Name = "text_StockStatus";
            this.text_StockStatus.ReadOnly = true;
            this.text_StockStatus.Size = new System.Drawing.Size(173, 22);
            this.text_StockStatus.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Seçilmiş olan Ürünün Güncel Stoğu : ";
            // 
            // Sıra
            // 
            this.Sıra.AutoSize = true;
            this.Sıra.Location = new System.Drawing.Point(372, 29);
            this.Sıra.Name = "Sıra";
            this.Sıra.Size = new System.Drawing.Size(31, 16);
            this.Sıra.TabIndex = 22;
            this.Sıra.Text = "Sıra";
            // 
            // text_Seri
            // 
            this.text_Seri.Location = new System.Drawing.Point(108, 30);
            this.text_Seri.Name = "text_Seri";
            this.text_Seri.ReadOnly = true;
            this.text_Seri.Size = new System.Drawing.Size(176, 22);
            this.text_Seri.TabIndex = 0;
            this.text_Seri.TextChanged += new System.EventHandler(this.text_Seri_TextChanged);
            // 
            // Seri
            // 
            this.Seri.AutoSize = true;
            this.Seri.Location = new System.Drawing.Point(30, 31);
            this.Seri.Name = "Seri";
            this.Seri.Size = new System.Drawing.Size(34, 16);
            this.Seri.TabIndex = 20;
            this.Seri.Text = "Seri:";
            // 
            // text_CompanyCode
            // 
            this.text_CompanyCode.Location = new System.Drawing.Point(107, 69);
            this.text_CompanyCode.Name = "text_CompanyCode";
            this.text_CompanyCode.ReadOnly = true;
            this.text_CompanyCode.Size = new System.Drawing.Size(176, 22);
            this.text_CompanyCode.TabIndex = 14;
            // 
            // combo_StockName
            // 
            this.combo_StockName.FormattingEnabled = true;
            this.combo_StockName.Location = new System.Drawing.Point(450, 105);
            this.combo_StockName.Name = "combo_StockName";
            this.combo_StockName.Size = new System.Drawing.Size(176, 24);
            this.combo_StockName.TabIndex = 3;
            this.combo_StockName.SelectedIndexChanged += new System.EventHandler(this.combo_StockName_SelectedIndexChanged);
            this.combo_StockName.TextChanged += new System.EventHandler(this.combo_StockName_TextChanged);
            this.combo_StockName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combo_StockName_MouseClick);
            // 
            // combo_CompanyName
            // 
            this.combo_CompanyName.FormattingEnabled = true;
            this.combo_CompanyName.Location = new System.Drawing.Point(450, 64);
            this.combo_CompanyName.Name = "combo_CompanyName";
            this.combo_CompanyName.Size = new System.Drawing.Size(176, 24);
            this.combo_CompanyName.TabIndex = 2;
            this.combo_CompanyName.SelectedIndexChanged += new System.EventHandler(this.combo_CompanyName_SelectedIndexChanged);
            this.combo_CompanyName.TextChanged += new System.EventHandler(this.combo_CompanyName_TextChanged);
            this.combo_CompanyName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combo_CompanyName_MouseClick);
            // 
            // btn_AddSaleList
            // 
            this.btn_AddSaleList.Image = global::GGMSYS.Properties.Resources.icons8_add_basket_30;
            this.btn_AddSaleList.Location = new System.Drawing.Point(632, 75);
            this.btn_AddSaleList.Name = "btn_AddSaleList";
            this.btn_AddSaleList.Size = new System.Drawing.Size(122, 47);
            this.btn_AddSaleList.TabIndex = 17;
            this.btn_AddSaleList.Text = "Sepete Ekle";
            this.btn_AddSaleList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddSaleList.UseVisualStyleBackColor = true;
            this.btn_AddSaleList.Click += new System.EventHandler(this.btn_AddSaleList_Click);
            // 
            // check_Input
            // 
            this.check_Input.AutoSize = true;
            this.check_Input.Location = new System.Drawing.Point(659, 189);
            this.check_Input.Name = "check_Input";
            this.check_Input.Size = new System.Drawing.Size(90, 20);
            this.check_Input.TabIndex = 6;
            this.check_Input.Text = "Ürün Girişi";
            this.check_Input.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cari İsmi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Firma Kodu:";
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(107, 210);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(519, 22);
            this.text_Search.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ara:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::GGMSYS.Properties.Resources.icons8_save_30;
            this.btn_Delete.Location = new System.Drawing.Point(632, 129);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(122, 47);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Image = global::GGMSYS.Properties.Resources.icons8_save_30;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Save.Location = new System.Drawing.Point(632, 21);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 47);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Kaydet  Güncelle";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // text_StockPrice
            // 
            this.text_StockPrice.Location = new System.Drawing.Point(450, 170);
            this.text_StockPrice.Name = "text_StockPrice";
            this.text_StockPrice.Size = new System.Drawing.Size(176, 22);
            this.text_StockPrice.TabIndex = 5;
            // 
            // text_SalesAmount
            // 
            this.text_SalesAmount.Location = new System.Drawing.Point(107, 167);
            this.text_SalesAmount.Name = "text_SalesAmount";
            this.text_SalesAmount.Size = new System.Drawing.Size(176, 22);
            this.text_SalesAmount.TabIndex = 4;
            // 
            // text_StockCode
            // 
            this.text_StockCode.Location = new System.Drawing.Point(107, 106);
            this.text_StockCode.Name = "text_StockCode";
            this.text_StockCode.ReadOnly = true;
            this.text_StockCode.Size = new System.Drawing.Size(176, 22);
            this.text_StockCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satış Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok İsmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.data_SaleList);
            this.groupBox3.Location = new System.Drawing.Point(7, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 487);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sepet Detayı";
            // 
            // data_SaleList
            // 
            this.data_SaleList.AllowUserToAddRows = false;
            this.data_SaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_SaleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsInStock,
            this.StockID,
            this.StockCode,
            this.StockName,
            this.Quantity,
            this.SalePrice,
            this.ClientID,
            this.CompanyName,
            this.Evrak_Seri,
            this.Evrak_Sira});
            this.data_SaleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_SaleList.Location = new System.Drawing.Point(3, 18);
            this.data_SaleList.Name = "data_SaleList";
            this.data_SaleList.ReadOnly = true;
            this.data_SaleList.RowHeadersWidth = 51;
            this.data_SaleList.RowTemplate.Height = 24;
            this.data_SaleList.Size = new System.Drawing.Size(754, 466);
            this.data_SaleList.TabIndex = 1;
            this.data_SaleList.TabStop = false;
            // 
            // IsInStock
            // 
            this.IsInStock.HeaderText = "Giriş Mi ?";
            this.IsInStock.MinimumWidth = 6;
            this.IsInStock.Name = "IsInStock";
            this.IsInStock.ReadOnly = true;
            this.IsInStock.Width = 125;
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stok ID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Visible = false;
            this.StockID.Width = 125;
            // 
            // StockCode
            // 
            this.StockCode.HeaderText = "Stok Kodu";
            this.StockCode.MinimumWidth = 6;
            this.StockCode.Name = "StockCode";
            this.StockCode.ReadOnly = true;
            this.StockCode.Width = 125;
            // 
            // StockName
            // 
            this.StockName.HeaderText = "Stok Adı";
            this.StockName.MinimumWidth = 6;
            this.StockName.Name = "StockName";
            this.StockName.ReadOnly = true;
            this.StockName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Miktar";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Birim Tutarı";
            this.SalePrice.MinimumWidth = 6;
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.Width = 125;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "Firma Kodu";
            this.ClientID.MinimumWidth = 6;
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Width = 125;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Firma Adı";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 125;
            // 
            // Evrak_Seri
            // 
            this.Evrak_Seri.HeaderText = "Evrak Serisi";
            this.Evrak_Seri.MinimumWidth = 6;
            this.Evrak_Seri.Name = "Evrak_Seri";
            this.Evrak_Seri.ReadOnly = true;
            this.Evrak_Seri.Width = 125;
            // 
            // Evrak_Sira
            // 
            this.Evrak_Sira.HeaderText = "Evrak Sırası";
            this.Evrak_Sira.MinimumWidth = 6;
            this.Evrak_Sira.Name = "Evrak_Sira";
            this.Evrak_Sira.ReadOnly = true;
            this.Evrak_Sira.Width = 125;
            // 
            // frm_Sales
            // 
            this.AcceptButton = this.btn_AddSaleList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 758);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_Sales";
            this.Text = "Alış/Satış";
            this.Load += new System.EventHandler(this.frm_Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sira)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_SaleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox text_StockPrice;
        private System.Windows.Forms.TextBox text_SalesAmount;
        private System.Windows.Forms.TextBox text_StockCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView data_SaleList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox check_Input;
        private System.Windows.Forms.Button btn_AddSaleList;
        private System.Windows.Forms.ComboBox combo_StockName;
        private System.Windows.Forms.ComboBox combo_CompanyName;
        private System.Windows.Forms.Label Sıra;
        private System.Windows.Forms.TextBox text_Seri;
        private System.Windows.Forms.Label Seri;
        private System.Windows.Forms.TextBox text_CompanyCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_StockStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evrak_Seri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evrak_Sira;
        private System.Windows.Forms.NumericUpDown numeric_Sira;
        private System.Windows.Forms.Label label9;
    }
}