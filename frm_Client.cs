using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GGMSYS
{
    public partial class frm_Client : Form
    {
        private DataTable clientsTable;

        public frm_Client()
        {
            InitializeComponent();
        }

        private void frm_Client_Load(object sender, EventArgs e)
        {
            RefreshClientList();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_ClientName.Text) || string.IsNullOrWhiteSpace(text_ClientSurname.Text))
            {
                MessageBox.Show("Lütfen müşteri adı ve soyadı alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ClientID = text_ClientID.Text.Trim();
            string companyName = text_CompanyName.Text.Trim();

            // Aynı firma kodu veya benzer firma adı olan firmaları kontrol et
            if (IsDuplicateClient(ClientID, companyName))
            {
                DialogResult result = MessageBox.Show("Bu firma kodu veya benzer bir firma adı zaten var. Kayıt yapmaya devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return; // Kayıt yapmamayı tercih ettiğinde işlemi sonlandır
                }
            }

            string commandText;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ClientName", text_ClientName.Text),
                new SqlParameter("@ClientSurname", text_ClientSurname.Text),
                new SqlParameter("@CompanyName", companyName),
                new SqlParameter("@ClientPhone", text_ClientPhone.Text),
                new SqlParameter("@ClientMail", text_ClientMail.Text),
                new SqlParameter("@CompanyPhoneNo", text_CompanyPhoneNo.Text),
                new SqlParameter("@CompanyAddress", text_CompanyAddress.Text),
                new SqlParameter("@SaleOff", check_SaleOff.Checked ? 1 : 0)
            };

            if (string.IsNullOrEmpty(text_ClientID.Tag as string)) // Yeni müşteri için
            {
                commandText = @"INSERT INTO Clients (ClientName, ClientSurname, CompanyName, ClientPhone, ClientMail, CompanyPhoneNo, CompanyAddress, SaleOff, CreateDate) 
                    VALUES (@ClientName, @ClientSurname, @CompanyName, @ClientPhone, @ClientMail, @CompanyPhoneNo, @CompanyAddress, @SaleOff, GETDATE())";
            }
            else // Mevcut müşteriyi güncelleme için
            {
                commandText = @"UPDATE Clients SET ClientName=@ClientName, ClientSurname=@ClientSurname, CompanyName=@CompanyName, 
                    ClientPhone=@ClientPhone, ClientMail=@ClientMail, CompanyPhoneNo=@CompanyPhoneNo, CompanyAddress=@CompanyAddress, SaleOff=@SaleOff, UpdateDate=GETDATE() 
                    WHERE ClientID=@ClientID";
                parameters.Add(new SqlParameter("@ClientID", Convert.ToInt32(text_ClientID.Tag))); // Güncelleme için ClientID parametresini ekleyin
            }

            DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters.ToArray());
            RefreshClientList(); // Müşteri listesini güncelle
            frm_Client_Load(sender, e); //Fromu yenile 
            MessageBox.Show("Müşteri bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsDuplicateClient(string ClientID, string companyName)
        {
            string commandText = "SELECT COUNT(*) FROM Clients WHERE ClientID = @ClientID OR CompanyName LIKE @CompanyName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", ClientID),
                new SqlParameter("@CompanyName", "%" + companyName + "%")
            };

            int count = Convert.ToInt32(DBHelper.ExecuteScalar(commandText, CommandType.Text, parameters));
            return count > 0;
        }

        private void data_CompanyList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = data_CompanyList.Rows[e.RowIndex];

                // Güncelleme için kullanılacak ClientID'yi sakla
                text_ClientID.Text = row.Cells["ClientID"].Value.ToString();

                text_ClientName.Text = row.Cells["ClientName"].Value.ToString();
                text_ClientSurname.Text = row.Cells["ClientSurname"].Value.ToString();
                text_CompanyName.Text = row.Cells["CompanyName"].Value.ToString();
                text_ClientPhone.Text = row.Cells["ClientPhone"].Value.ToString();
                text_ClientMail.Text = row.Cells["ClientMail"].Value.ToString();
                text_CompanyPhoneNo.Text = row.Cells["CompanyPhoneNo"].Value.ToString();
                text_CompanyAddress.Text = row.Cells["CompanyAddress"].Value.ToString();
                check_SaleOff.Checked = Convert.ToBoolean(row.Cells["SaleOff"].Value);

                text_ClientID.Tag = row.Cells["ClientID"].Value.ToString(); // Güncelleme için kullanılacak Tag
            }
        }

        private void RefreshClientList()
        {
            string commandText = @"
        SELECT 
            ClientID as 'Müşteri ID', 
            CompanyName as 'Firma Adı', 
            CompanyPhoneNo as 'Firma Numarası', 
            ClientName as 'Müşteri Adı', 
            ClientSurname as 'Müşteri Soyadı', 
            ClientPhone as 'Müşteri Numarası', 
            ClientMail as 'Müşteri Mail', 
            CompanyAddress as 'Firma Adresi', 
            SaleOff as 'Satışa Kapalı?' 
        FROM Clients";

            DataTable clientsTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
            data_CompanyList.DataSource = clientsTable;
            data_CompanyList.RowHeadersVisible = false; // Hides the row header column

            // Clear the text fields
            text_ClientID.Clear();
            text_ClientName.Clear();
            text_ClientSurname.Clear();
            text_ClientPhone.Clear();
            text_ClientMail.Clear();
            text_CompanyPhoneNo.Clear();
            text_CompanyAddress.Clear();
            text_CompanySearch.Clear();
            text_CompanyName.Clear();
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // text_ClientID.Tag değerinin boş olmadığını ve bir sayıya dönüştürülebileceğini kontrol ediyoruz.
            if (text_ClientID.Tag != null && int.TryParse(text_ClientID.Tag.ToString(), out int clientID))
            {
                // İlk olarak, müşteriye ait satış veya alış kaydı olup olmadığını kontrol ediyoruz.
                string checkSalesCommandText = "SELECT COUNT(*) FROM Sales WHERE ClientID = @ClientID";
                SqlParameter[] checkSalesParameters = { new SqlParameter("@ClientID", clientID) };

                int salesCount = Convert.ToInt32(DBHelper.ExecuteScalar(checkSalesCommandText, CommandType.Text, checkSalesParameters));

                if (salesCount > 0)
                {
                    MessageBox.Show("Bu müşteri üzerinde alış veya satış işlemi olduğundan silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Seçilen kaydı silmek istediğinize emin misiniz?", "Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string commandText = "DELETE FROM Clients WHERE ClientID = @ClientID";
                    SqlParameter[] parameters = { new SqlParameter("@ClientID", clientID) };

                    int rowsAffected = DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshClientList(); // Listeyi yenileyerek silinen kaydın artık listelenmemesini sağlıyoruz.
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir sorun oluştu veya silinecek kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void text_CompanySearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_CompanySearch.Text.ToLower();
            DataView dv = clientsTable.DefaultView;
            dv.RowFilter = string.Format("CompanyName LIKE '%{0}%'", searchText);
            data_CompanyList.DataSource = dv;
        }
    }
}
