using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GGMSYS
{
    public partial class frm_Sales : Form
    {
        private int selectedSaleId = -1;
        private int selectedCartId = -1;

        public frm_Sales()
        {
            InitializeComponent();
        }

        private void frm_Sales_Load(object sender, EventArgs e)
        {
            FillCompanyComboBox();
            FillStockComboBox();
            //RefreshSalesList();
            ClearFormSave();
        }

        private void FillCompanyComboBox()
        {
            string commandText = "SELECT ClientID, CompanyName FROM Clients WHERE SaleOff = 0";
            DataTable companiesTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
            combo_CompanyName.DataSource = companiesTable;
            combo_CompanyName.DisplayMember = "CompanyName";
            combo_CompanyName.ValueMember = "ClientID";
        }

        private void FillStockComboBox()
        {
            string commandText = "SELECT StockID, StockName, StockPrice, StockQuantity FROM Stocks";
            DataTable stockTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
            combo_StockName.DataSource = stockTable;
            combo_StockName.DisplayMember = "StockName";
            combo_StockName.ValueMember = "StockID";
        }

        //private void RefreshSalesList()
        //{
        //    string commandText = "SELECT StockID, Evrak_Seri, Evrak_Sira, ClientID, Quantity, SalePrice, TotalAmount, TotalQuantity, IsInStock, CreateDate, UpdateDate FROM Sales";
        //    DataTable cartTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
        //    data_SaleList.DataSource = cartTable;
        //}



        private void ClearForm()
        {
            text_SalesAmount.Clear();
            text_StockPrice.Clear();
            text_StockCode.Clear();
            combo_StockName.SelectedIndex = -1;
            check_Input.Checked = false;
        }

        private void ClearFormSave()
        {
            text_SalesAmount.Clear();
            text_Seri.Clear();
            //text_Sira.Clear();
            text_StockPrice.Clear();
            text_StockCode.Clear();
            combo_StockName.SelectedIndex = -1;
            combo_CompanyName.SelectedIndex = -1;
            check_Input.Checked = false;
        }

        //private void LoadSaleDetails(int cartId)
        //{
        //    string query = "SELECT StockID, Evrak_Seri, Evrak_Sira, ClientID, Quantity, SalePrice, TotalAmount, TotalQuantity, IsInStock, CreateDate, UpdateDate FROM Sales WHERE SaleID = @SaleID";
        //    SqlParameter[] parameters = { new SqlParameter("@CartID", cartId) };
        //    DataTable cartDetails = DBHelper.ExecuteSelectCommand(query, CommandType.Text, parameters);

        //    if (cartDetails.Rows.Count > 0)
        //    {
        //        DataRow row = cartDetails.Rows[0];
        //        combo_StockName.SelectedValue = row["StockID"];
        //        combo_CompanyName.SelectedValue = row["ClientID"];
        //        text_SalesAmount.Text = row["Quantity"].ToString();
        //        text_StockPrice.Text = row["SalePrice"].ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sepet öğesi detayları yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void combo_CompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_CompanyName.SelectedIndex != -1)
            {
                DataRowView drv = combo_CompanyName.SelectedItem as DataRowView;
                if (drv != null)
                {
                    text_CompanyCode.Text = drv["ClientID"].ToString();
                    string companyName = drv["CompanyName"].ToString();
                    string evrakSeri = new string(companyName.Split(' ').Select(word => word[0]).ToArray()).ToUpper();
                    text_Seri.Text = evrakSeri;

                    // Sira numarasını oluştur
                    GenerateEvrakSira(evrakSeri);
                }
            }
            else
            {
                text_CompanyCode.Text = string.Empty;
                text_Seri.Text = string.Empty;
            }
        }


        private void combo_StockName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_StockName.SelectedIndex != -1)
            {
                int stockId = Convert.ToInt32(combo_StockName.SelectedValue);

                // StockID'ye göre StockQuantity değerini al
                string commandText = "SELECT StockCode, StockPrice, StockQuantity FROM Stocks WHERE StockID = @StockID";
                SqlParameter[] parameters = { new SqlParameter("@StockID", stockId) };
                DataTable stockDetails = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text, parameters);

                if (stockDetails.Rows.Count > 0)
                {
                    DataRow row = stockDetails.Rows[0];
                    text_StockCode.Text = row["StockCode"].ToString();
                    text_StockPrice.Text = row["StockPrice"].ToString();
                    text_StockStatus.Text = row["StockQuantity"].ToString();
                }
                else
                {
                    text_StockPrice.Text = string.Empty;
                    text_StockStatus.Text = string.Empty;
                }
            }
            else
            {
                text_StockCode.Text = string.Empty;
                text_StockPrice.Text = string.Empty;
                text_StockStatus.Text = string.Empty;
            }
        }


        private void btn_AddSaleList_Click(object sender, EventArgs e)
        {
            if (combo_StockName.SelectedIndex == -1 || combo_CompanyName.SelectedIndex == -1 || string.IsNullOrWhiteSpace(text_SalesAmount.Text) || string.IsNullOrWhiteSpace(text_StockPrice.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (data_SaleList.Rows.Count > 0)
            {
                // Evrak seri ve sıra numaraları değiştirilemez hale getiriliyor
                text_Seri.Enabled = false;
                numeric_Sira.Enabled = false;
                //text_Sira.Enabled = false;
            }

            int stockId = Convert.ToInt32(combo_StockName.SelectedValue);
            int clientId = Convert.ToInt32(combo_CompanyName.SelectedValue);
            int quantity = Convert.ToInt32(text_SalesAmount.Text);
            decimal salePrice = Convert.ToDecimal(text_StockPrice.Text);
            string evrakSeri = text_Seri.Text;
            int evrakSira = Convert.ToInt32(numeric_Sira.Value);
            bool isInStock = check_Input.Checked;
            int stockCode = Convert.ToInt32(text_StockCode.Text);

            data_SaleList.Rows.Add(
                isInStock ? "Giriş" : "Çıkış",
                stockId,
                stockCode,
                combo_StockName.Text,   // Stok Adı
                quantity,
                salePrice,
                clientId,
                combo_CompanyName.Text, // Firma Adı
                evrakSeri,
                evrakSira

                
            );

            // TextBox ve ComboBox'ları temizle
            ClearForm();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (data_SaleList.Rows.Count == 0)
            {
                MessageBox.Show("Kaydedilecek ürün yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (DataGridViewRow row in data_SaleList.Rows)
                {
                    string evrakSeri = row.Cells["Evrak_Seri"].Value.ToString();
                    int evrakSira = Convert.ToInt32(row.Cells["Evrak_Sira"].Value);
                    int clientId = Convert.ToInt32(row.Cells["ClientID"].Value);
                    int stockId = Convert.ToInt32(row.Cells["StockID"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal salePrice = Convert.ToDecimal(row.Cells["SalePrice"].Value);
                    bool isInStock = row.Cells["IsInStock"].Value.ToString() == "Giriş";

                    // Sales tablosuna kayıt ekle
                    string commandText = @"INSERT INTO Sales (Evrak_Seri, Evrak_Sira, ClientID, StockID, Quantity, SalePrice, TotalAmount, TotalQuantity, IsInStock, CreateDate, UpdateDate)
                           VALUES (@Evrak_Seri, @Evrak_Sira, @ClientID, @StockID, @Quantity, @SalePrice, @TotalAmount, @TotalQuantity, @IsInStock, GETDATE(), GETDATE())";
                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Evrak_Seri", evrakSeri),
                new SqlParameter("@Evrak_Sira", evrakSira),
                new SqlParameter("@ClientID", clientId),
                new SqlParameter("@StockID", stockId),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@SalePrice", salePrice),
                new SqlParameter("@TotalAmount", quantity * salePrice),
                new SqlParameter("@TotalQuantity", quantity),
                new SqlParameter("@IsInStock", isInStock)
            };

                    DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters.ToArray());
                }

                MessageBox.Show("Satış başarıyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Form ve listeleri sıfırla
                ClearFormSave();
                frm_Sales_Load(sender, e);
                data_SaleList.Rows.Clear();
                text_Seri.Enabled = true;
                numeric_Sira.Enabled = true;
                //text_Sira.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //    private void UpdateStockQuantity(int stockID, int quantityChange)
        //    {
        //        string commandText = "UPDATE Stocks SET StockQuantity = StockQuantity + @QuantityChange, UpdateDate = GETDATE() WHERE StockID = @StockID";
        //        SqlParameter[] parameters = {
        //    new SqlParameter("@QuantityChange", quantityChange),
        //    new SqlParameter("@StockID", stockID)
        //};

        //        DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        //    }

        private void text_Seri_TextChanged(object sender, EventArgs e)
        {
            string evrakSeri = text_Seri.Text;

            if (string.IsNullOrWhiteSpace(evrakSeri))
            {
                data_SaleList.Rows.Clear();
                return;
            }

            GenerateEvrakSira(evrakSeri);
        }

        //private void text_Sira_TextChanged(object sender, EventArgs e)
        //{
        //    string evrakSeri = text_Seri.Text;
        //    int evrakSira;

        //    if (string.IsNullOrWhiteSpace(evrakSeri) || !int.TryParse(text_Sira.Text, out evrakSira))
        //    {
        //        data_SaleList.Rows.Clear();
        //        return;
        //    }

        //    UpdateDataSaleList(evrakSeri, evrakSira);
        //}

        private void GenerateEvrakSira(string evrakSeri)
        {
            try
            {
                // Mevcut en büyük sıra numarasını bul ve +1 ekle
                string commandText = @"SELECT ISNULL(MAX(Evrak_Sira), 0) + 1 AS NextSira
                               FROM Sales
                               WHERE Evrak_Seri = @EvrakSeri";
                SqlParameter[] parameters = {
            new SqlParameter("@EvrakSeri", evrakSeri)
        };

                object result = DBHelper.ExecuteScalar(commandText, CommandType.Text, parameters);
                if (result != null)
                {
                    int evrakSira = Convert.ToInt32(result);
                    numeric_Sira.ValueChanged -= numeric_Sira_ValueChanged; // Geçici olarak ValueChanged olayını kaldır
                    numeric_Sira.Value = evrakSira; // Değeri atar
                    numeric_Sira.ValueChanged += numeric_Sira_ValueChanged; // ValueChanged olayını tekrar ekle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateDataSaleList(string evrakSeri, int evrakSira)
        {
            try
            {
                // Sales tablosunda arama yap
                string commandText = @"SELECT Evrak_Seri, Evrak_Sira, ClientID, StockID, Quantity, SalePrice, IsInStock
                               FROM Sales
                               WHERE Evrak_Seri = @EvrakSeri AND Evrak_Sira = @EvrakSira";
                SqlParameter[] parameters = {
            new SqlParameter("@EvrakSeri", evrakSeri),
            new SqlParameter("@EvrakSira", evrakSira)
        };

                DataTable resultTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text, parameters);

                data_SaleList.Rows.Clear();
                if (resultTable.Rows.Count > 0)
                {
                    // DataGridView'i güncelle
                    foreach (DataRow row in resultTable.Rows)
                    {
                        data_SaleList.Rows.Add(
                            row["Evrak_Seri"],
                            row["Evrak_Sira"],
                            row["ClientID"],
                            row["StockID"],
                            row["Quantity"],
                            row["SalePrice"],
                            row["IsInStock"].ToString() == "True" ? "Giriş" : "Çıkış"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combo_CompanyName_TextChanged(object sender, EventArgs e)
        {
            // Olay işleyicilerini geçici olarak devre dışı bırakın
            combo_CompanyName.TextChanged -= combo_CompanyName_TextChanged;

            string filterText = combo_CompanyName.Text;

            string commandText = "SELECT ClientID, CompanyName FROM Clients WHERE SaleOff = 0 AND CompanyName LIKE @FilterText";
            SqlParameter[] parameters = {
        new SqlParameter("@FilterText", "%" + filterText + "%")
    };

            DataTable filteredTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text, parameters);

            combo_CompanyName.DataSource = filteredTable;
            combo_CompanyName.DisplayMember = "CompanyName";
            combo_CompanyName.ValueMember = "ClientID";

            /*combo_CompanyName.DroppedDown = false;*/ // Otomatik olarak açılır listeyi açar
            combo_CompanyName.IntegralHeight = true; // Otomatik olarak yüksekliği ayarlar
            combo_CompanyName.SelectedIndex = -1; // Metni korur
            combo_CompanyName.Text = filterText; // Metni korur
            combo_CompanyName.SelectionStart = filterText.Length; // İmleci metnin sonuna taşır

            // Olay işleyicilerini yeniden etkinleştirin
            combo_CompanyName.TextChanged += combo_CompanyName_TextChanged;
        }

        private void combo_CompanyName_MouseClick(object sender, MouseEventArgs e)
        {
            combo_CompanyName.DroppedDown = true;
        }

        private void combo_StockName_MouseClick(object sender, MouseEventArgs e)
        {
            combo_StockName.DroppedDown = true;
        }

        private void combo_StockName_TextChanged(object sender, EventArgs e)
        {
            // Olay işleyicilerini geçici olarak devre dışı bırakın
            combo_StockName.TextChanged -= combo_StockName_TextChanged;

            string filterText = combo_StockName.Text;

            string commandText = "SELECT StockID, StockName, StockPrice FROM Stocks WHERE StockName LIKE @FilterText";
            SqlParameter[] parameters = {
        new SqlParameter("@FilterText", "%" + filterText + "%")
    };

            DataTable filteredTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text, parameters);

            combo_StockName.DataSource = filteredTable;
            combo_StockName.DisplayMember = "StockName";
            combo_StockName.ValueMember = "StockID";

            //combo_StockName.DroppedDown = true; // Otomatik olarak açılır listeyi açar
            combo_StockName.IntegralHeight = true; // Otomatik olarak yüksekliği ayarlar
            combo_StockName.SelectedIndex = -1; // Metni korur
            combo_StockName.Text = filterText; // Metni korur
            combo_StockName.SelectionStart = filterText.Length; // İmleci metnin sonuna taşır

            // Olay işleyicilerini yeniden etkinleştirin
            combo_StockName.TextChanged += combo_StockName_TextChanged;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string evrakSeri = text_Seri.Text;
            int evrakSira = (int)numeric_Sira.Value;

            // Evrak seri veya sıra boşsa işlem yapma
            if (string.IsNullOrWhiteSpace(evrakSeri) || evrakSira <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir Evrak Seri ve Sıra giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DataGridView'de bir satır seçiliyse, bu satırı sil
            if (data_SaleList.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Seçili satırları silmek istediğinizden emin misiniz?", "Satırları Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in data_SaleList.SelectedRows)
                    {
                        int rowIndex = row.Index;

                        // Sales tablosundan seçili satırı sil
                        int stockId = Convert.ToInt32(row.Cells["StockID"].Value);
                        int clientId = Convert.ToInt32(row.Cells["ClientID"].Value);
                        decimal salePrice = Convert.ToDecimal(row.Cells["SalePrice"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        string isInStock = row.Cells["IsInStock"].Value.ToString() == "Giriş" ? "True" : "False";

                        // Check if the sale or purchase exists for the client
                        string checkCommandText = @"SELECT COUNT(*) FROM Sales
                                            WHERE ClientID = @ClientID";
                        SqlParameter[] checkParameters = {
                    new SqlParameter("@ClientID", clientId)
                };

                        int saleCount = (int)DBHelper.ExecuteScalar(checkCommandText, CommandType.Text, checkParameters);

                        if (saleCount > 0)
                        {
                            MessageBox.Show("Bu müşteriden alış veya satış olduğundan kayıt silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string deleteCommandText = @"DELETE FROM Sales
                                             WHERE Evrak_Seri = @EvrakSeri AND Evrak_Sira = @EvrakSira
                                             AND StockID = @StockID AND ClientID = @ClientID
                                             AND SalePrice = @SalePrice AND Quantity = @Quantity
                                             AND IsInStock = @IsInStock";
                        SqlParameter[] deleteParameters = {
                    new SqlParameter("@EvrakSeri", evrakSeri),
                    new SqlParameter("@EvrakSira", evrakSira),
                    new SqlParameter("@StockID", stockId),
                    new SqlParameter("@ClientID", clientId),
                    new SqlParameter("@SalePrice", salePrice),
                    new SqlParameter("@Quantity", quantity),
                    new SqlParameter("@IsInStock", isInStock)
                };

                        DBHelper.ExecuteNonQuery(deleteCommandText, CommandType.Text, deleteParameters);

                        // DataGridView'den seçili satırı sil
                        data_SaleList.Rows.RemoveAt(rowIndex);
                    }
                    MessageBox.Show("Seçili satırlar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Belirtilen Evrak Seri ve Sıra ile eşleşen tüm kayıtları silmek istediğinizden emin misiniz?", "Kayıtları Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Sales tablosundan tüm eşleşen kayıtları sil
                        string commandText = @"DELETE FROM Sales
                                       WHERE Evrak_Seri = @EvrakSeri AND Evrak_Sira = @EvrakSira";
                        SqlParameter[] parameters = {
                    new SqlParameter("@EvrakSeri", evrakSeri),
                    new SqlParameter("@EvrakSira", evrakSira)
                };

                        int rowsAffected = DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıtlar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            data_SaleList.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen Evrak Seri ve Sıra ile eşleşen kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void numeric_Sira_ValueChanged(object sender, EventArgs e)
        {
            string evrakSeri = text_Seri.Text;
            int evrakSira = (int)numeric_Sira.Value;

            if (string.IsNullOrWhiteSpace(evrakSeri))
            {
                data_SaleList.Rows.Clear();
                return;
            }

            UpdateDataSaleList(evrakSeri, evrakSira);
        }
    }

}
