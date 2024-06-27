# GGMSYS Windows Forms Application

This is a Windows Forms application developed in C# using Visual Studio. The application includes functionalities for managing clients, sales, and stock activities. The application is designed to be responsive and includes features for exporting data to Excel files.

## Features

- **Client Management**: Add, edit, and delete client information. Export client data to Excel.
- **Sales Management**: View and filter sales data. Export sales data to Excel.
- **Stock Management**: View stock information. Export stock data to Excel.
- **Responsive Design**: The application is designed to be responsive, adjusting the layout based on the window size.

## Getting Started

### Prerequisites

- .NET Framework
- Visual Studio
- ClosedXML library for Excel export

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/aoaydin/ggmsys.git
    ```

2. Open the solution in Visual Studio.

3. Restore the NuGet packages:
    ```sh
    Install-Package ClosedXML
    ```

4. Build and run the application.

## Usage

### Client Management

- **View Clients**: Display all clients with their details.
- **Export Clients to Excel**: Click the "Export Clients" button to save client data to an Excel file. The system will prompt you to choose the save location.

### Sales Management

- **View Sales**: Display all sales with detailed information including client and stock details.
- **Filter Sales**: Filter sales data based on various criteria.
- **Export Sales to Excel**: Click the "Export Sales" button to save sales data to an Excel file. The system will prompt you to choose the save location.

### Stock Management

- **View Stock**: Display all stock items with their details.
- **Export Stock to Excel**: Click the "Export Stock" button to save stock data to an Excel file. The system will prompt you to choose the save location.


## App Pictures

![Login](https://raw.githubusercontent.com/aoaydin/GGMSYS/master/apppic/1.png?token=GHSAT0AAAAAACS52C4YEUUYX42OUVVZRXSGZT5FSSQ)
![Main Menu](https://raw.githubusercontent.com/aoaydin/GGMSYS/master/apppic/2.png?token=GHSAT0AAAAAACS52C4YEUUYX42OUVVZRXSGZT5FSSQ)

## Code Examples



### Load Sales Data

```csharp
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
