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
    StockPiece VARCHAR(100), -- Bu alanýn amacý net deðil, daha iyi bir isimlendirme gerekebilir.
    StockPrice DECIMAL(18, 2),
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME
);

-- Cart Table 
CREATE TABLE Cart (
    CartID INT PRIMARY KEY IDENTITY(1,1),
	CartGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
	ClientID INT,
    StockID INT,
    Quantity INT,
    SalePrice DECIMAL(18, 2),
    IsInStock BIT, -- 0: Giriþ, 1: Çýkýþ
    StockActivityType VARCHAR(10), -- 'Sale', 'Purchase', 'Return' gibi.
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME,
    FOREIGN KEY (StockID) REFERENCES Stocks(StockID),
	FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- Sales Table
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    SaleGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
    ClientID INT,
	CartID INT,
	StockID INT,
    Quantity INT,
    SalePrice DECIMAL(18, 2),
    SaleDate DATETIME,
    TotalAmount DECIMAL(18, 2), -- Sepet tutarý topamý burada yazacak
	TotalProduct DECIMAL(18, 2), -- Sepet içerisi ürünlerin kaç adet olduðu yazacak
    CreateDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME,
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
	FOREIGN KEY (CartID) REFERENCES Cart(CartID),
	FOREIGN KEY (StockID) REFERENCES Stocks(StockID)
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


