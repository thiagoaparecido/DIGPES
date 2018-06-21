-- =============================================
-- Create database DIGPES
-- =============================================
USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'DIGPES'
)
DROP DATABASE DIGPES
GO

CREATE DATABASE DIGPES
GO