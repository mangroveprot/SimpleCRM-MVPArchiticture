-- Create the database
CREATE DATABASE CRM_DB;
GO

-- Use the database
USE CRM_DB;
GO

-- Create the customers table
CREATE TABLE customers (
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

-- Insert 100 sample rows into the customers table
DECLARE @i INT = 1;

WHILE @i <= 100
BEGIN
    INSERT INTO customers (
        first_name,
        middle_name,
        last_name,
        suffix,
        email,
        phone_number
    )
    VALUES (
        CONCAT('FirstName', @i),
        CONCAT('Middle', @i),
        CONCAT('LastName', @i),
        CASE WHEN @i % 4 = 0 THEN 'Jr.' 
             WHEN @i % 4 = 1 THEN 'Sr.' 
             WHEN @i % 4 = 2 THEN 'II'
             ELSE NULL END,
        CONCAT('user', @i, '@example.com'),
        CONCAT('555-000-', RIGHT('0000' + CAST(@i AS VARCHAR), 4))
    );

    SET @i = @i + 1;
END;

GO

CREATE TABLE Products (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name NVARCHAR(100) NOT NULL,
    description NVARCHAR(255) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    stock_quantity INT NOT NULL
);

CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL UNIQUE,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(100) NOT NULL UNIQUE,
    full_name NVARCHAR(100) NOT NULL
);

CREATE TABLE Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    product_id INT NULL,  -- Allow NULL values in product_id for ON DELETE SET NULL
    quantity INT NOT NULL,
    total_amount DECIMAL(10, 2) NOT NULL,
    status VARCHAR(20) NOT NULL,
    date DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Customer FOREIGN KEY (customer_id) 
        REFERENCES Customers(customer_id)
        ON DELETE CASCADE,  -- When customer is deleted, delete associated orders
    CONSTRAINT FK_Product FOREIGN KEY (product_id) 
        REFERENCES Products(product_id)
        ON DELETE SET NULL  -- When product is deleted, set product_id to NULL in orders
);


-- example order output
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
JOIN Products P ON O.product_id = P.product_id;

