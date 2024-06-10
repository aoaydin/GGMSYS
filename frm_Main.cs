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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

       

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            frm_Stock frm_Stock = new frm_Stock();
            frm_Stock.ShowDialog();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            frm_Client frm_Client = new frm_Client();
            frm_Client.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_Sales frm_Sales = new frm_Sales();
            frm_Sales.ShowDialog();
        }

        private void btn_StockActivity_Click(object sender, EventArgs e)
        {
            frm_StockActivity frm_StockActivity = new frm_StockActivity();
            frm_StockActivity.ShowDialog();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            frm_Reports frm_Reports = new frm_Reports();
            frm_Reports.ShowDialog();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            frm_Users frm_Users = new frm_Users();
            frm_Users.ShowDialog();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Desing : Abdurrahman AYDIN\nCoder : Abdurrahman AYDIN\nYılı : 2024";
            string caption = "Bilgilendirme";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Mesaj kutusunu göster ve kullanıcı tamam düğmesine tıkladığında işlem yap
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                // Mesaj kutusu tamam düğmesine tıklanarak kapatıldı
                // İstenilen işlemler burada yapılabilir
            }
        }
    }
}
