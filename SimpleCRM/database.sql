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