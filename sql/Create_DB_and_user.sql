CREATE DATABASE webgoat;
GO

CREATE LOGIN webgoat_user
	WITH PASSWORD = 'Top_Secret1';
GO

CREATE USER webgoat_user FOR LOGIN webgoat_user
	WITH DEFAULT_SCHEMA = webgoat;
GO