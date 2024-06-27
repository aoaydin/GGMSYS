namespace GGMSYS
{
    partial class frm_StockActivity
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
            this.btn_Fliter = new System.Windows.Forms.Button();
            this.text_EvrakSira = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_StockName = new System.Windows.Forms.ComboBox();
            this.combo_CompanyName = new System.Windows.Forms.ComboBox();
            this.date_EndTime = new System.Windows.Forms.DateTimePicker();
            this.date_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_EvrakSeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_FilterOutput = new System.Windows.Forms.RadioButton();
            this.radio_FilterInput = new System.Windows.Forms.RadioButton();
            this.radio_FilterAll = new System.Windows.Forms.RadioButton();
            this.text_StockCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_StockActivity = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_StockActivity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Fliter);
            this.groupBox1.Controls.Add(this.text_EvrakSira);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combo_StockName);
            this.groupBox1.Controls.Add(this.combo_CompanyName);
            this.groupBox1.Controls.Add(this.date_EndTime);
            this.groupBox1.Controls.Add(this.date_StartTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_EvrakSeri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radio_FilterOutput);
            this.groupBox1.Controls.Add(this.radio_FilterInput);
            this.groupBox1.Controls.Add(this.radio_FilterAll);
            this.groupBox1.Controls.Add(this.text_StockCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flitreler";
            // 
            // btn_Fliter
            // 
            this.btn_Fliter.Image = global::GGMSYS.Properties.Resources.icons8_filter_30;
            this.btn_Fliter.Location = new System.Drawing.Point(607, 118);
            this.btn_Fliter.Name = "btn_Fliter";
            this.btn_Fliter.Size = new System.Drawing.Size(137, 38);
            this.btn_Fliter.TabIndex = 21;
            this.btn_Fliter.Text = "Fitrele";
            this.btn_Fliter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Fliter.UseVisualStyleBackColor = true;
            this.btn_Fliter.Click += new System.EventHandler(this.btn_Fliter_Click);
            // 
            // text_EvrakSira
            // 
            this.text_EvrakSira.Location = new System.Drawing.Point(349, 134);
            this.text_EvrakSira.Name = "text_EvrakSira";
            this.text_EvrakSira.Size = new System.Drawing.Size(170, 22);
            this.text_EvrakSira.TabIndex = 20;
            this.text_EvrakSira.TextChanged += new System.EventHandler(this.text_EvrakSira_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Evrak Sıra:";
            // 
            // combo_StockName
            // 
            this.combo_StockName.FormattingEnabled = true;
            this.combo_StockName.Location = new System.Drawing.Point(87, 60);
            this.combo_StockName.Name = "combo_StockName";
            this.combo_StockName.Size = new System.Drawing.Size(170, 24);
            this.combo_StockName.TabIndex = 18;
            // 
            // combo_CompanyName
            // 
            this.combo_CompanyName.FormattingEnabled = true;
            this.combo_CompanyName.Location = new System.Drawing.Point(87, 26);
            this.combo_CompanyName.Name = "combo_CompanyName";
            this.combo_CompanyName.Size = new System.Drawing.Size(170, 24);
            this.combo_CompanyName.TabIndex = 17;
            // 
            // date_EndTime
            // 
            this.date_EndTime.Location = new System.Drawing.Point(607, 66);
            this.date_EndTime.Name = "date_EndTime";
            this.date_EndTime.Size = new System.Drawing.Size(137, 22);
            this.date_EndTime.TabIndex = 16;
            this.date_EndTime.ValueChanged += new System.EventHandler(this.date_EndTime_ValueChanged);
            // 
            // date_StartTime
            // 
            this.date_StartTime.Location = new System.Drawing.Point(607, 32);
            this.date_StartTime.Name = "date_StartTime";
            this.date_StartTime.Size = new System.Drawing.Size(137, 22);
            this.date_StartTime.TabIndex = 15;
            this.date_StartTime.ValueChanged += new System.EventHandler(this.date_StartTime_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bitiş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Başlangıç Tarihi:";
            // 
            // text_EvrakSeri
            // 
            this.text_EvrakSeri.Location = new System.Drawing.Point(87, 131);
            this.text_EvrakSeri.Name = "text_EvrakSeri";
            this.text_EvrakSeri.Size = new System.Drawing.Size(170, 22);
            this.text_EvrakSeri.TabIndex = 12;
            this.text_EvrakSeri.TextChanged += new System.EventHandler(this.text_EvrakSeri_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Evrak Seri:";
            // 
            // radio_FilterOutput
            // 
            this.radio_FilterOutput.AutoSize = true;
            this.radio_FilterOutput.Location = new System.Drawing.Point(366, 95);
            this.radio_FilterOutput.Name = "radio_FilterOutput";
            this.radio_FilterOutput.Size = new System.Drawing.Size(57, 20);
            this.radio_FilterOutput.TabIndex = 10;
            this.radio_FilterOutput.Text = "Çıkış";
            this.radio_FilterOutput.UseVisualStyleBackColor = true;
            this.radio_FilterOutput.CheckedChanged += new System.EventHandler(this.radio_FilterOutput_CheckedChanged);
            // 
            // radio_FilterInput
            // 
            this.radio_FilterInput.AutoSize = true;
            this.radio_FilterInput.Location = new System.Drawing.Point(366, 60);
            this.radio_FilterInput.Name = "radio_FilterInput";
            this.radio_FilterInput.Size = new System.Drawing.Size(55, 20);
            this.radio_FilterInput.TabIndex = 9;
            this.radio_FilterInput.Text = "Giriş";
            this.radio_FilterInput.UseVisualStyleBackColor = true;
            this.radio_FilterInput.CheckedChanged += new System.EventHandler(this.radio_FilterInput_CheckedChanged);
            // 
            // radio_FilterAll
            // 
            this.radio_FilterAll.AutoSize = true;
            this.radio_FilterAll.Checked = true;
            this.radio_FilterAll.Location = new System.Drawing.Point(366, 27);
            this.radio_FilterAll.Name = "radio_FilterAll";
            this.radio_FilterAll.Size = new System.Drawing.Size(62, 20);
            this.radio_FilterAll.TabIndex = 8;
            this.radio_FilterAll.TabStop = true;
            this.radio_FilterAll.Text = "Tümü";
            this.radio_FilterAll.UseVisualStyleBackColor = true;
            this.radio_FilterAll.CheckedChanged += new System.EventHandler(this.radio_FilterAll_CheckedChanged);
            // 
            // text_StockCode
            // 
            this.text_StockCode.Location = new System.Drawing.Point(87, 95);
            this.text_StockCode.Name = "text_StockCode";
            this.text_StockCode.Size = new System.Drawing.Size(170, 22);
            this.text_StockCode.TabIndex = 5;
            this.text_StockCode.TextChanged += new System.EventHandler(this.text_StockCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı:";
            // 
            // data_StockActivity
            // 
            this.data_StockActivity.AllowUserToAddRows = false;
            this.data_StockActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_StockActivity.Location = new System.Drawing.Point(0, 25);
            this.data_StockActivity.Name = "data_StockActivity";
            this.data_StockActivity.ReadOnly = true;
            this.data_StockActivity.RowHeadersWidth = 51;
            this.data_StockActivity.RowTemplate.Height = 24;
            this.data_StockActivity.Size = new System.Drawing.Size(795, 553);
            this.data_StockActivity.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.data_StockActivity);
            this.groupBox2.Location = new System.Drawing.Point(2, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 578);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Haraketleri";
            // 
            // frm_StockActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_StockActivity";
            this.Text = "Stok Haraketleri";
            this.Load += new System.EventHandler(this.frm_StockActivity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_StockActivity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_StockActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_EvrakSeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_FilterOutput;
        private System.Windows.Forms.RadioButton radio_FilterInput;
        private System.Windows.Forms.RadioButton radio_FilterAll;
        private System.Windows.Forms.TextBox text_StockCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date_EndTime;
        private System.Windows.Forms.DateTimePicker date_StartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_StockName;
        private System.Windows.Forms.ComboBox combo_CompanyName;
        private System.Windows.Forms.TextBox text_EvrakSira;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Fliter;
    }
}