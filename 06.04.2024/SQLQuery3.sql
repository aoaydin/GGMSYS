-- Users Table
CREATE TABLE Users (
  UserID INT PRIMARY KEY IDENTITY,
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
  ClientID INT PRIMARY KEY IDENTITY,
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
  StockID INT PRIMARY KEY IDENTITY,
  StockGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
  StockCode VARCHAR(50),
  StockName VARCHAR(100),
  StockPiece VARCHAR(50),
  StockPrice DECIMAL(18, 2),
  CreateDate DATETIME DEFAULT GETDATE(),
  UpdateDate DATETIME
);
-- Sales Table (Simplified)
CREATE TABLE Sales (
  SaleID INT PRIMARY KEY IDENTITY,
  SaleGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
  ClientID INT,
  TotalAmount DECIMAL(18, 2),
  SaleDate DATETIME DEFAULT GETDATE(),
  CreateDate DATETIME DEFAULT GETDATE(),
  UpdateDate DATETIME,
  FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);


-- Cart Table (Updated to include SaleID)
CREATE TABLE Cart (
  CartID INT PRIMARY KEY IDENTITY,
  CartGUID UNIQUEIDENTIFIER DEFAULT NEWID(),
  ClientID INT,
  StockID INT,
  Quantity INT,
  SalePrice DECIMAL(18, 2),
  IsInStock BIT,
  StockActivityType VARCHAR(10),
  SaleID INT NULL, -- Updated: References the SaleID once the sale is finalized
  CreateDate DATETIME DEFAULT GETDATE(),
  UpdateDate DATETIME,
  FOREIGN KEY (StockID) REFERENCES Stocks(StockID),
  FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
  FOREIGN KEY (SaleID) REFERENCES Sales(SaleID) -- New foreign key constraint
);

