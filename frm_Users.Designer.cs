namespace GGMSYS
{
    partial class frm_Users
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
            this.text_Username = new System.Windows.Forms.TextBox();
            this.text_UserID = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.text_Surname = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.check_DeActive = new System.Windows.Forms.CheckBox();
            this.check_Admin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_UserList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_Username);
            this.groupBox1.Controls.Add(this.text_UserID);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.text_Surname);
            this.groupBox1.Controls.Add(this.text_Name);
            this.groupBox1.Controls.Add(this.text_Password);
            this.groupBox1.Controls.Add(this.check_DeActive);
            this.groupBox1.Controls.Add(this.check_Admin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgisi";
            // 
            // text_Username
            // 
            this.text_Username.Location = new System.Drawing.Point(121, 36);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(301, 22);
            this.text_Username.TabIndex = 0;
            // 
            // text_UserID
            // 
            this.text_UserID.Location = new System.Drawing.Point(281, 36);
            this.text_UserID.Name = "text_UserID";
            this.text_UserID.ReadOnly = true;
            this.text_UserID.Size = new System.Drawing.Size(35, 22);
            this.text_UserID.TabIndex = 12;
            // 
            // btn_Delete
            // 
            this.btn_Delete.CausesValidation = false;
            this.btn_Delete.Location = new System.Drawing.Point(321, 190);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(62, 52);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(244, 190);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(71, 52);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Kaydet Güncelle";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // text_Surname
            // 
            this.text_Surname.Location = new System.Drawing.Point(121, 138);
            this.text_Surname.Name = "text_Surname";
            this.text_Surname.Size = new System.Drawing.Size(301, 22);
            this.text_Surname.TabIndex = 3;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(121, 106);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(301, 22);
            this.text_Name.TabIndex = 2;
            // 
            // text_Password
            // 
            this.text_Password.Location = new System.Drawing.Point(121, 70);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(301, 22);
            this.text_Password.TabIndex = 1;
            // 
            // check_DeActive
            // 
            this.check_DeActive.AutoSize = true;
            this.check_DeActive.Location = new System.Drawing.Point(121, 190);
            this.check_DeActive.Name = "check_DeActive";
            this.check_DeActive.Size = new System.Drawing.Size(59, 20);
            this.check_DeActive.TabIndex = 5;
            this.check_DeActive.Text = "Pasif";
            this.check_DeActive.UseVisualStyleBackColor = true;
            // 
            // check_Admin
            // 
            this.check_Admin.AutoSize = true;
            this.check_Admin.Location = new System.Drawing.Point(31, 190);
            this.check_Admin.Name = "check_Admin";
            this.check_Admin.Size = new System.Drawing.Size(67, 20);
            this.check_Admin.TabIndex = 4;
            this.check_Admin.Text = "Admin";
            this.check_Admin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_UserList);
            this.groupBox2.Location = new System.Drawing.Point(2, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Listesi";
            // 
            // data_UserList
            // 
            this.data_UserList.AllowUserToAddRows = false;
            this.data_UserList.AllowUserToDeleteRows = false;
            this.data_UserList.AllowUserToOrderColumns = true;
            this.data_UserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_UserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_UserList.Location = new System.Drawing.Point(3, 18);
            this.data_UserList.MultiSelect = false;
            this.data_UserList.Name = "data_UserList";
            this.data_UserList.ReadOnly = true;
            this.data_UserList.RowHeadersWidth = 51;
            this.data_UserList.RowTemplate.Height = 24;
            this.data_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_UserList.Size = new System.Drawing.Size(485, 259);
            this.data_UserList.TabIndex = 0;
            this.data_UserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_UserList_CellDoubleClick);
            // 
            // frm_Users
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_Users";
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.frm_Users_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.CheckBox check_DeActive;
        private System.Windows.Forms.CheckBox check_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox text_Surname;
        private System.Windows.Forms.DataGridView data_UserList;
        private System.Windows.Forms.TextBox text_UserID;
    }
}