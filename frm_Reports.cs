using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGMSYS
{
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void btn_StockList_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Retrieve data from the Stocks table
                string query = @"
            SELECT 
                StockCode AS 'Stok Kodu', 
                StockName AS 'Stok Adı', 
                StockQuantity AS 'Miktar', 
                StockPrice AS 'Fiyat' 
            FROM Stocks";

                DataTable stocksTable = DBHelper.ExecuteSelectCommand(query, CommandType.Text);

                // Step 2: Export data to an Excel file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Dosyaları|*.xlsx";
                    saveFileDialog.Title = "Bir Excel Dosyası Kaydedin";
                    saveFileDialog.FileName = "Stoklar.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Stocks");
                            worksheet.Cell(1, 1).InsertTable(stocksTable);
                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show("Stok verileri başarıyla Excel'e aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok verileri aktarılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ClientList_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Retrieve data from the Clients table
                string query = @"
        SELECT 
            ClientID AS 'Müşteri Kodu', 
            CompanyName AS 'Firma Adı',
            CompanyPhoneNo AS 'Firma Numarası',
            ClientName AS 'Yetkili Adı',
            ClientSurname AS 'Yetkili Soyadı',
            ClientPhone AS 'Yetkili Telefon', 
            ClientMail AS 'E-Posta',
            CASE 
                WHEN SaleOff = 1 THEN 'Satışa Kapalı'
                ELSE 'Satışa Açık'
            END AS 'Satış Durumu'
        FROM Clients";

                DataTable clientsTable = DBHelper.ExecuteSelectCommand(query, CommandType.Text);

                // Step 2: Export data to an Excel file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Dosyaları|*.xlsx";
                    saveFileDialog.Title = "Bir Excel Dosyası Kaydedin";
                    saveFileDialog.FileName = "Clients.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Clients");
                            worksheet.Cell(1, 1).InsertTable(clientsTable);
                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show("Müşteri verileri başarıyla Excel'e aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri verileri aktarılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
