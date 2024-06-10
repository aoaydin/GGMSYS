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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = combo_UserName.Text;
            string password = text_Password.Text;

            if (username == "" && password == "")
            {
                this.Hide();
                frm_Main mainForm = new frm_Main();
                mainForm.Show();
            }
            else
            {

                string commandText = "SELECT IsActive, IsAdmin FROM Users WHERE Username = @Username AND Password = @Password";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password)
                };

                DataTable resultTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text, parameters);

                if (resultTable.Rows.Count > 0)
                {
                    bool isActive = Convert.ToBoolean(resultTable.Rows[0]["IsActive"]);
                    bool isAdmin = Convert.ToBoolean(resultTable.Rows[0]["IsAdmin"]);

                    if (!isActive)
                    {
                        MessageBox.Show("Kullanıcınız deaktif edilmiş.");
                        return;
                    }

                    this.Hide();
                    frm_Main mainForm = new frm_Main();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FillUsernames()
        {
            // Sadece aktif kullanıcıları seçecek 
            string commandText = "SELECT Username FROM Users WHERE IsActive = 1";
            DataTable usersTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);

            combo_UserName.Items.Clear(); // ComboBox'ı temizle

            foreach (DataRow row in usersTable.Rows)
            {
                combo_UserName.Items.Add(row["Username"].ToString());
            }

            //if (combo_UserName.Items.Count > 0)
            //{
            //    combo_UserName.SelectedIndex = 0; // İlk elemanı varsayılan olarak seç
            //}
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {
            FillUsernames();
        }
    }
}
