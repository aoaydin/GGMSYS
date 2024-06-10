using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGMSYS
{
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Alanların doluluğunu kontrol et
            if (string.IsNullOrWhiteSpace(text_Username.Text) ||
                string.IsNullOrWhiteSpace(text_Password.Text) ||
                string.IsNullOrWhiteSpace(text_Name.Text) ||
                string.IsNullOrWhiteSpace(text_Surname.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parametreleri hazırla
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@Username", text_Username.Text),
        new SqlParameter("@Password", text_Password.Text),
        new SqlParameter("@Name", text_Name.Text),
        new SqlParameter("@Surname", text_Surname.Text),
        new SqlParameter("@IsAdmin", check_Admin.Checked ? 1 : 0),
        new SqlParameter("@IsActive", !check_DeActive.Checked ? 1 : 0),
    };

            string commandText;

            // Yeni kullanıcı ekleme veya mevcut kullanıcıyı güncelleme
            if (int.TryParse(text_UserID.Text, out int userID))
            {
                // Mevcut kullanıcıyı güncelle
                commandText = @"UPDATE Users SET Username=@Username, Password=@Password, Name=@Name, Surname=@Surname, 
                        IsAdmin=@IsAdmin, IsActive=@IsActive, UpdateDate=GETDATE() WHERE UserID=@UserID";
                parameters.Add(new SqlParameter("@UserID", userID));
            }
            else
            {
                // Yeni kullanıcı ekle
                commandText = @"INSERT INTO Users (Username, Password, Name, Surname, IsAdmin, IsActive, CreateDate) 
                        VALUES (@Username, @Password, @Name, @Surname, @IsAdmin, @IsActive, GETDATE())";
            }
            DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters.ToArray());
            RefreshUserList();
            frm_Users_Load(sender, e);
            MessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void RefreshUserList()
        {
            string commandText = "SELECT UserID, Username, Password, Name, Surname, IsAdmin, IsActive FROM Users";
            DataTable usersTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
            data_UserList.DataSource = usersTable;
            data_UserList.RowHeadersVisible = false; // datagrid içerisinde ilk stunu gizliyor.

            text_Name.Clear();
            text_Surname.Clear();
            text_Username.Clear();
            text_UserID.Clear();
            text_Password.Clear();

            //////////////////////////////////////
            ///Row adlarını düzenle /////////////
            data_UserList.Columns["Username"].HeaderText = "Kullanıcı Adı";
            data_UserList.Columns["Password"].HeaderText = "Şifre";
            data_UserList.Columns["Name"].HeaderText = "Adı";
            data_UserList.Columns["Surname"].HeaderText = "Soyadı";
            data_UserList.Columns["IsActive"].HeaderText = "Aktif Kullanıcı";
            data_UserList.Columns["IsAdmin"].HeaderText = "Admin";

            /////////////////////////////////////////////

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_UserID.Text) && int.TryParse(text_UserID.Text, out int userID))
            {
                DialogResult dialogResult = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcıyı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string commandText = "DELETE FROM Users WHERE UserID=@UserID";
                    SqlParameter[] parameters = { new SqlParameter("@UserID", userID) };

                    int rowsAffected = DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshUserList(); // Kullanıcı listesini yenile
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinirken bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void data_UserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = data_UserList.Rows[e.RowIndex];
                text_UserID.Text = row.Cells["UserID"].Value.ToString(); // UserID'yi sakla

                // Diğer kullanıcı bilgilerini de ilgili TextBox'lara atayabilirsiniz
                text_Username.Text = row.Cells["Username"].Value.ToString();
                text_Password.Text = row.Cells["Password"].Value.ToString();
                text_Name.Text = row.Cells["Name"].Value.ToString();
                text_Surname.Text = row.Cells["Surname"].Value.ToString();
                check_Admin.Checked = Convert.ToBoolean(row.Cells["IsAdmin"].Value);
                check_DeActive.Checked = !Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }


        private void frm_Users_Load(object sender, EventArgs e)
        {
            RefreshUserList();
           
        }
    }
}

