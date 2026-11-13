-- MSSQL (SQL Server) Database Setup
IF DB_ID('activity3_db') IS NULL
    CREATE DATABASE activity3_db;
GO

USE activity3_db;
GO

IF OBJECT_ID('users', 'U') IS NULL
BEGIN
    CREATE TABLE users (
        id INT IDENTITY(1,1) PRIMARY KEY,
        username VARCHAR(50) NOT NULL UNIQUE,
        password VARCHAR(100) NOT NULL,
        fullname VARCHAR(100) NOT NULL
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM users WHERE username = 'admin')
BEGIN
    INSERT INTO users (username, password, fullname) VALUES
    ('admin', 'admin123', 'Administrator');
END
GO