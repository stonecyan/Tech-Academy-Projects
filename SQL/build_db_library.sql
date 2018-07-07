USE [master]
GO

CREATE PROCEDURE [dbo].[Build_db_library]
AS
BEGIN

	/******************************************************
	 * The following prevents any errors from occuring
	 * if the database or tables already exist.
	 * This code will close all active connections to the 
	 * database and then drop it
	 ******************************************************/

	WHILE EXISTS(select * from sys.databases where name='db_library')
	BEGIN
		DECLARE @SQL varchar(max)
		SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
		FROM MASTER.sys.sysprocesses
		WHERE DBId = DB_ID(N'db_library') AND SPId <> @@SPId
		EXEC(@SQL)
		DROP DATABASE [db_library]
	END
	/******************************************************
	 * The following demonstrates a stored proceedure to 
	 * build the database, tables and then populate the 
	 * tables with data.
	 ******************************************************/

	CREATE DATABASE db_library

END

GO