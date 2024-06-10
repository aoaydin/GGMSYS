-- Users Table (Deðiþiklik yok)
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

-- Clients Table (Deðiþiklik yok)
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

-- Stocks Table (Deðiþiklik yok)
CREATE TABLE Stocks (
  StockID INT PRIMARY KEY IDENTITY(1,1),
  StockGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
  StockCode VARCHAR(50),
  StockName VARCHAR(100),
  StockPiece VARCHAR(50), -- Daha açýklayýcý isim
  StockPrice DECIMAL(18, 2),
  CreateDate DATETIME DEFAULT GETDATE(),
  UpdateDate DATETIME
);

-- Cart Table (Deðiþiklik yok)
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

-- Sales Table (Deðiþiklikler)
CREATE TABLE Sales (
  SaleID INT PRIMARY KEY IDENTITY(1,1),
  SaleGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
  ClientID INT,
  -- CartID foreign key'i kaldýrdýk (bir satýþ birden fazla üründen oluþabilir)
  StockID INT,  -- Satýlan ürünün StockID'si
  Quantity INT,
  SalePrice DECIMAL(18, 2),
  SaleDate DATETIME,
  TotalAmount DECIMAL(18, 2), -- Tetikleyici veya uygulama logic'inde hesaplanacak
  TotalProduct INT,  -- Yeni sütun: Sepetteki toplam ürün adedi
  CreateDate DATETIME DEFAULT GETDATE(),
  UpdateDate DATETIME,
  FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
  FOREIGN KEY (StockID) REFERENCES Stocks(StockID)
);

-- StockActivities Table (Deðiþiklik yok)
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


CREATE TABLE SalesCart (
  SalesCartID INT PRIMARY KEY IDENTITY(1,1),
  SaleID INT,
  CartID INT,
  FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
  FOREIGN KEY (CartID) REFERENCES Cart(CartID)
);