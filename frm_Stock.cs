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
    public partial class frm_Stock : Form
    {
        public frm_Stock()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Gerekli alanların kontrolü
            if (string.IsNullOrWhiteSpace(text_StockCode.Text) ||
                string.IsNullOrWhiteSpace(text_StockName.Text) ||
                string.IsNullOrWhiteSpace(text_StockPrice.Text))
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string commandText;
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@StockCode", text_StockCode.Text),
        new SqlParameter("@StockName", text_StockName.Text),
        new SqlParameter("@StockQuantity", text_Stock.Text),
        new SqlParameter("@StockPrice", decimal.Parse(text_StockPrice.Text))
    };

            if (string.IsNullOrEmpty(text_StockCode.Tag as string)) // Yeni stok ekleme
            {
                commandText = @"INSERT INTO Stocks (StockCode, StockName, StockQuantity, StockPrice, CreateDate) 
                        VALUES (@StockCode, @StockName, @StockQuantity, @StockPrice, GETDATE())";
            }
            else // Stok güncelleme
            {
                commandText = @"UPDATE Stocks SET StockCode=@StockCode, StockName=@StockName, StockQuantity=@StockQuantity, StockPrice=@StockPrice, UpdateDate=GETDATE() 
                        WHERE StockID=@StockID";
                parameters.Add(new SqlParameter("@StockID", int.Parse(text_StockCode.Tag.ToString()))); // Güncelleme için StockID
            }

            DBHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters.ToArray());
            RefreshStockList();
            frm_Stock_Load(sender, e);
            MessageBox.Show("Stok bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshStockList()
        {
            string commandText = @"
        SELECT 
            StockID, 
            StockCode as 'Stok Kodu', 
            StockName as 'Stok Adı', 
            StockQuantity as 'Stok Miktarı', 
            StockPrice as 'Fiyatı', 
            CreateDate as 'Oluşturma Tarihi', 
            UpdateDate as 'Güncelleme Tarihi'
        FROM Stocks";

            DataTable stockTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
            data_StockList.DataSource = stockTable;

            // Hide ID and date columns
            data_StockList.Columns["StockID"].Visible = false;
            data_StockList.Columns["Oluşturma Tarihi"].Visible = false;
            data_StockList.Columns["Güncelleme Tarihi"].Visible = false;

            // Adjust column sizes
            data_StockList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_StockList.RowHeadersVisible = false;

            // Clear the text fields
            text_Stock.Clear();
            text_StockCode.Clear();
            text_StockPrice.Clear();
            text_StockSearch.Clear();
            text_StockName.Clear();
        }


        private void data_StockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = data_StockList.Rows[e.RowIndex];
                text_StockCode.Tag = row.Cells["StockID"].Value.ToString(); // Güncelleme için StockID'yi sakla
                text_StockCode.Text = row.Cells["StockCode"].Value.ToString();
                text_StockName.Text = row.Cells["StockName"].Value.ToString();
                text_Stock.Text = row.Cells["StockQuantity"].Value.ToString();
                text_StockPrice.Text = row.Cells["StockPrice"].Value.ToString();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_StockCode.Tag as string))
            {
                DialogResult dialogResult = MessageBox.Show("Seçilen stok kaydını silmek istediğinize emin misiniz?", "Stok Kaydını Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int stockID = Convert.ToInt32(text_StockCode.Tag);
                    string checkSalesCommandText = "SELECT COUNT(*) FROM Sales WHERE StockID = @StockID";
                    SqlParameter[] checkSalesParameters = { new SqlParameter("@StockID", stockID) };

                    int salesCount = Convert.ToInt32(DBHelper.ExecuteScalar(checkSalesCommandText, CommandType.Text, checkSalesParameters));

                    if (salesCount > 0)
                    {
                        MessageBox.Show("Bu stok kaydı üzerinde satış veya alış işlemi olduğundan silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string deleteCommandText = "DELETE FROM Stocks WHERE StockID = @StockID";
                    SqlParameter[] deleteParameters = { new SqlParameter("@StockID", stockID) };

                    DBHelper.ExecuteNonQuery(deleteCommandText, CommandType.Text, deleteParameters);
                    RefreshStockList();
                    MessageBox.Show("Stok kaydı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz stok kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void frm_Stock_Load(object sender, EventArgs e)
        {
            RefreshStockList();
            SetNextStockCode();
        }

        private void SetNextStockCode()
        {
            string commandText = "SELECT ISNULL(MAX(CAST(StockCode AS INT)), 99) + 1 FROM Stocks";
            object result = DBHelper.ExecuteScalar(commandText, CommandType.Text);

            if (result != null)
            {
                text_StockCode.Text = result.ToString();
            }
            else
            {
                text_StockCode.Text = "100";
            }
        }

        private void text_StockSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_StockSearch.Text.ToLower();
            foreach (DataGridViewRow row in data_StockList.Rows)
            {
                if (row.Cells["StockName"].Value != null)
                {
                    string stockName = row.Cells["StockName"].Value.ToString().ToLower();
                    row.Visible = stockName.Contains(searchText);
                }
            }
        }
    }
}