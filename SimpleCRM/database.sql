-- Create the database
IF DB_ID('CRM_DB') IS NULL
    CREATE DATABASE CRM_DB;
GO

-- Use the database
USE CRM_DB;
GO

-- Drop existing tables if re-running the script
IF OBJECT_ID('Orders', 'U') IS NOT NULL DROP TABLE Orders;
IF OBJECT_ID('Users', 'U') IS NOT NULL DROP TABLE Users;
IF OBJECT_ID('Products', 'U') IS NOT NULL DROP TABLE Products;
IF OBJECT_ID('Customers', 'U') IS NOT NULL DROP TABLE Customers;
GO

-- Create the customers table
CREATE TABLE Customers (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(50) NOT NULL,
    middle_name NVARCHAR(50),
    last_name NVARCHAR(50) NOT NULL,
    suffix NVARCHAR(10),
    email NVARCHAR(100) UNIQUE,
    phone_number NVARCHAR(15),
    created_at DATETIME DEFAULT GETDATE()
);
GO

-- Create the products table
CREATE TABLE Products (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name NVARCHAR(100) NOT NULL,
    description NVARCHAR(255) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    stock_quantity INT NOT NULL
);
GO

-- Create the users table
CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL UNIQUE,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(100) NOT NULL UNIQUE,
    full_name NVARCHAR(100) NOT NULL
);
GO

-- Create the orders table
CREATE TABLE Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    product_id INT NULL,
    quantity INT NOT NULL,
    total_amount DECIMAL(10, 2) NOT NULL,
    status VARCHAR(20) NOT NULL,
    date DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Customer FOREIGN KEY (customer_id) 
        REFERENCES Customers(customer_id)
        ON DELETE CASCADE,
    CONSTRAINT FK_Product FOREIGN KEY (product_id) 
        REFERENCES Products(product_id)
        ON DELETE SET NULL
);
GO

-- Sample order output query
SELECT 
    O.order_id, 
    O.status, 
    O.quantity, 
    O.total_amount, 
    C.customer_id, 
    C.first_name + ' ' + C.last_name AS customer_name, 
    P.product_id, 
    P.product_name, 
    P.price AS product_price,
    O.date AS order_date
FROM Orders O
JOIN Customers C ON O.customer_id = C.customer_id
LEFT JOIN Products P ON O.product_id = P.product_id;
GO
