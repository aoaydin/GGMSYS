using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GGMSYS
{
    public partial class frm_StockActivity : Form
    {
        public frm_StockActivity()
        {
            InitializeComponent();
        }

        private void frm_StockActivity_Load(object sender, EventArgs e)
        {
            FillCompanyComboBox();
            FillStockComboBox();
            LoadSalesData();
        }

        private void FillCompanyComboBox()
        {
            try
            {
                string commandText = "SELECT ClientID, CompanyName FROM Clients WHERE SaleOff = 0";
                DataTable companiesTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
                combo_CompanyName.DataSource = companiesTable;
                combo_CompanyName.DisplayMember = "CompanyName";
                combo_CompanyName.ValueMember = "ClientID";
                combo_CompanyName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillStockComboBox()
        {
            try
            {
                string commandText = "SELECT StockID, StockName, StockCode FROM Stocks";
                DataTable stockTable = DBHelper.ExecuteSelectCommand(commandText, CommandType.Text);
                combo_StockName.DataSource = stockTable;
                combo_StockName.DisplayMember = "StockName";
                combo_StockName.ValueMember = "StockID";
                combo_StockName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSalesData()
        {
            try
            {
                string query = @"
            SELECT 
                s.Evrak_Seri AS 'Evrak Seri', 
                s.Evrak_Sira AS 'Evrak Sıra', 
                s.ClientID AS 'Müşteri Kodu', 
                c.CompanyName AS 'Firma Adı', 
                st.StockCode AS 'Stok Kodu', 
                st.StockName AS 'Stok Adı', 
                s.Quantity AS 'Miktar', 
                s.SalePrice AS 'Satış Fiyatı', 
                (s.Quantity * s.SalePrice) AS 'Toplam Tutar', 
                s.Quantity AS 'Toplam Miktar', 
                CASE WHEN s.IsInStock = 1 THEN 'Giriş' ELSE 'Çıkış' END AS 'Stok Durumu', 
                s.CreateDate AS 'Oluşturma Tarihi', 
                s.UpdateDate AS 'Güncelleme Tarihi'
            FROM Sales s
            JOIN Stocks st ON s.StockID = st.StockID
            JOIN Clients c ON s.ClientID = c.ClientID";
                DataTable salesTable = DBHelper.ExecuteSelectCommand(query, CommandType.Text);
                data_StockActivity.DataSource = salesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış verileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void combo_CompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void combo_StockName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_StockName.SelectedIndex != -1)
            {
                DataRowView drv = combo_StockName.SelectedItem as DataRowView;
                if (drv != null)
                {
                    text_StockCode.Text = drv["StockCode"].ToString();
                }
            }
            else
            {
                text_StockCode.Text = string.Empty;
            }
            FilterSales();
        }


        private void FilterSales()
        {
            try
            {
                string query = @"
            SELECT 
                s.Evrak_Seri AS 'Evrak Seri', 
                s.Evrak_Sira AS 'Evrak Sıra', 
                s.ClientID AS 'Müşteri Kodu', 
                c.CompanyName AS 'Firma Adı', 
                st.StockCode AS 'Stok Kodu', 
                st.StockName AS 'Stok Adı', 
                s.Quantity AS 'Miktar', 
                s.SalePrice AS 'Satış Fiyatı', 
                (s.Quantity * s.SalePrice) AS 'Toplam Tutar', 
                s.Quantity AS 'Toplam Miktar', 
                CASE WHEN s.IsInStock = 1 THEN 'Giriş' ELSE 'Çıkış' END AS 'Stok Durumu', 
                s.CreateDate AS 'Oluşturma Tarihi', 
                s.UpdateDate AS 'Güncelleme Tarihi'
            FROM Sales s
            JOIN Stocks st ON s.StockID = st.StockID
            JOIN Clients c ON s.ClientID = c.ClientID
            WHERE 1=1";

                List<SqlParameter> parameters = new List<SqlParameter>();

                if (combo_CompanyName.SelectedIndex != -1)
                {
                    query += " AND s.ClientID = @ClientID";
                    parameters.Add(new SqlParameter("@ClientID", combo_CompanyName.SelectedValue));
                }

                if (combo_StockName.SelectedIndex != -1)
                {
                    query += " AND s.StockID = @StockID";
                    parameters.Add(new SqlParameter("@StockID", combo_StockName.SelectedValue));
                }

                if (!string.IsNullOrWhiteSpace(text_StockCode.Text))
                {
                    query += " AND s.StockID IN (SELECT StockID FROM Stocks WHERE StockCode = @StockCode)";
                    parameters.Add(new SqlParameter("@StockCode", text_StockCode.Text));
                }

                if (!string.IsNullOrWhiteSpace(text_EvrakSeri.Text))
                {
                    query += " AND s.Evrak_Seri = @EvrakSeri";
                    parameters.Add(new SqlParameter("@EvrakSeri", text_EvrakSeri.Text));
                }

                if (!string.IsNullOrWhiteSpace(text_EvrakSira.Text))
                {
                    query += " AND s.Evrak_Sira = @EvrakSira";
                    parameters.Add(new SqlParameter("@EvrakSira", text_EvrakSira.Text));
                }

                if (radio_FilterInput.Checked)
                {
                    query += " AND s.IsInStock = 1";
                }
                else if (radio_FilterOutput.Checked)
                {
                    query += " AND s.IsInStock = 0";
                }

                if (date_StartTime.Value.Date != DateTime.Now.Date || date_EndTime.Value.Date != DateTime.Now.Date)
                {
                    query += " AND s.CreateDate BETWEEN @StartTime AND @EndTime";
                    parameters.Add(new SqlParameter("@StartTime", date_StartTime.Value));
                    parameters.Add(new SqlParameter("@EndTime", date_EndTime.Value));
                }

                DataTable filteredTable = DBHelper.ExecuteSelectCommand(query, CommandType.Text, parameters.ToArray());
                data_StockActivity.DataSource = filteredTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void radio_FilterAll_CheckedChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void text_StockCode_TextChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void text_EvrakSeri_TextChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void text_EvrakSira_TextChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void radio_FilterInput_CheckedChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void radio_FilterOutput_CheckedChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void date_StartTime_ValueChanged(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void btn_Fliter_Click(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void date_EndTime_ValueChanged(object sender, EventArgs e)
        {
            FilterSales();
        }
    }
}
