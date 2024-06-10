-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
    Username VARCHAR(50),
    Password VARCHAR(50),
    Name VARCHAR(50),
    Surname VARCHAR(50),
    IsAdmin BIT,
    IsActive BIT,
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME
);

-- Clients Table
CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    ClientGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
    ClientName VARCHAR(50),
    ClientSurname VARCHAR(50),
    CompanyName VARCHAR(100),
    ClientPhone VARCHAR(20),
    ClientMail VARCHAR(100),
    CompanyPhoneNo VARCHAR(20),
    CompanyAddress VARCHAR(255),
    SaleOff BIT,
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME
);

-- Stocks Table
CREATE TABLE Stocks (
    StockID INT PRIMARY KEY IDENTITY(1,1),
    StockGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
    StockCode VARCHAR(50),
    StockName VARCHAR(100),
    StockQuantity INT, -- Daha anlamlý bir isim
    StockPrice DECIMAL(18, 2),
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME
);

-- Sales Table 
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    SaleGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
    Evrak_Seri VARCHAR(10),
    Evrak_Sira INT,
    ClientID INT,
    StockID INT,
    Quantity INT,
    SalePrice DECIMAL(18, 2),
    TotalAmount DECIMAL(18, 2), -- Sepet tutarý toplamý burada yazacak
    TotalQuantity INT, -- Sepet içerisi ürünlerin kaç adet olduðu yazacak
    IsInStock BIT, -- 0: Giriþ, 1: Çýkýþ
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME,
    FOREIGN KEY (StockID) REFERENCES Stocks(StockID),
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- StockActivities Table
CREATE TABLE StockActivities (
    ActivityID INT PRIMARY KEY IDENTITY(1,1),
    ActivityGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
    StockID INT,
    SaleID INT NULL, -- Her stok hareketi bir satýþla iliþkili olmayabilir.
    ActivityType VARCHAR(10), -- 'Sale', 'Purchase', 'Return' gibi.
    Quantity INT,
    UnitPrice DECIMAL(18, 2),
    ActivityDate DATETIME,
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME,
    FOREIGN KEY (StockID) REFERENCES Stocks(StockID),
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID) ON DELETE SET NULL
);

-- Triggers to manage stock quantity based on Sales
CREATE TRIGGER trg_UpdateStockOnSaleInsert
ON Sales
AFTER INSERT
AS
BEGIN
    UPDATE Stocks
    SET StockQuantity = StockQuantity - i.Quantity
    FROM inserted i
    WHERE Stocks.StockID = i.StockID;
END;

CREATE TRIGGER trg_UpdateStockOnSaleDelete
ON Sales
AFTER DELETE
AS
BEGIN
    UPDATE Stocks
    SET StockQuantity = StockQuantity + d.Quantity
    FROM deleted d
    WHERE Stocks.StockID = d.StockID;
END;

CREATE TRIGGER trg_UpdateStockOnSaleUpdate
ON Sales
AFTER UPDATE
AS
BEGIN
    UPDATE Stocks
    SET StockQuantity = StockQuantity + d.Quantity - i.Quantity
    FROM inserted i, deleted d
    WHERE Stocks.StockID = i.StockID AND Stocks.StockID = d.StockID;
END;


