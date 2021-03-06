USE [ROKI_EDI]
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerImport]    Script Date: 10-Oct-2018 16:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[sp_CustomerImport]
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	--By 1256 20181010
	UPDATE [CustomerImport] SET [Status] = 'Error' WHERE Code IS NULL OR Name IS NULL
	DECLARE @AutoId DECIMAL(18,0)
    , @Code NVARCHAR(50)
    , @Name NVARCHAR(250)
    , @Code2 NVARCHAR(50)
    , @Code3 NVARCHAR(50)
    , @Contact NVARCHAR(250)
    , @Address NVARCHAR(500)
    , @City NVARCHAR(50)
    , @State NVARCHAR(50)
    , @Country NVARCHAR(50)
    , @ZIPCode NVARCHAR(50)
    , @Phone NVARCHAR(50)
    , @Mobile NVARCHAR(50)
    , @Fax NVARCHAR(50)
    , @Email NVARCHAR(250)
    , @PaymentTermId INT
    , @CurrencyId INT
    , @ShipmentModeId INT
    , @PortLoadId INT
    , @PortDischargeId INT
    , @LocationCode NVARCHAR(50)
    , @CustCategoryId INT
    , @VatRate DECIMAL(18,2)
    , @Remark NVARCHAR(500)
    , @AddressCode NVARCHAR(50)
    , @PlantCode NVARCHAR(50)
	DECLARE iCursor CURSOR FOR
	SELECT [AutoId]
    ,[Code]
    ,[Name]
    ,[Code2]
    ,[Code3]
    ,[Contact]
    ,[Address]
    ,[City]
    ,[State]
    ,[Country]
    ,[ZIPCode]
    ,[Phone]
    ,[Mobile]
    ,[Fax]
    ,[Email]
    ,[PaymentTermId]
    ,[CurrencyId]
    ,[ShipmentModeId]
    ,[PortLoadId]
    ,[PortDischargeId]
    ,[LocationCode]
    ,[CustCategoryId]
    ,[VatRate]
    ,[Remark]
    ,[AddressCode]
    ,[PlantCode]
	FROM [CustomerImport]
	OPEN iCursor
	FETCH NEXT FROM iCursor INTO @AutoId
    , @Code
    , @Name
    , @Code2
    , @Code3
    , @Contact
    , @Address
    , @City
    , @State
    , @Country
    , @ZIPCode
    , @Phone
    , @Mobile
    , @Fax
    , @Email
    , @PaymentTermId
    , @CurrencyId
    , @ShipmentModeId
    , @PortLoadId
    , @PortDischargeId
    , @LocationCode
    , @CustCategoryId
    , @VatRate
    , @Remark
    , @AddressCode
    , @PlantCode
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF EXISTS(SELECT 1 FROM Customer WHERE Code = @Code AND Name = @Name)
		BEGIN
			--Update to Customer
			UPDATE Customer SET Code2 = @Code2
			, Code3 = @Code3
			, Contact = @Contact
			, Address = @Address
			, City = @City
			, State = @State
			, Country = @Country
			, ZIPCode = @ZIPCode
			, Phone = @Phone
			, Mobile = @Mobile
			, Fax = @Fax
			, Email = @Email
			, PaymentTermId = @PaymentTermId
			, CurrencyId = @CurrencyId
			, ShipmentModeId = @ShipmentModeId
			, PortLoadId = @PortLoadId
			, PortDischargeId = @PortDischargeId
			, LocationCode = @LocationCode
			, CustCategoryId = @CustCategoryId
			, VatRate = @VatRate
			, Remark = @Remark
			, AddressCode = @AddressCode
			, PlantCode = @PlantCode
			, UpdateBy = @UserName
			, UpdateDate = GETDATE()
			WHERE Code = @Code AND Name = @Name
		END
		ELSE
		BEGIN
			--Insert to Customer
			INSERT INTO [dbo].[Customer] 
			([Code]
			,[Name]
			,[Code2]
			,[Code3]
			,[Contact]
			,[Address]
			,[City]
			,[State]
			,[Country]
			,[ZIPCode]
			,[Phone]
			,[Mobile]
			,[Fax]
			,[Email]
			,[PaymentTermId]
			,[CurrencyId]
			,[ShipmentModeId]
			,[PortLoadId]
			,[PortDischargeId]
			,[LocationCode]
			,[CustCategoryId]
			,[VatRate]
			,[Remark]
			,[AddressCode]
			,[PlantCode]
			,[CreateBy]
			)
			SELECT [Code]
			,[Name]
			,[Code2]
			,[Code3]
			,[Contact]
			,[Address]
			,[City]
			,[State]
			,[Country]
			,[ZIPCode]
			,[Phone]
			,[Mobile]
			,[Fax]
			,[Email]
			,[PaymentTermId]
			,[CurrencyId]
			,[ShipmentModeId]
			,[PortLoadId]
			,[PortDischargeId]
			,[LocationCode]
			,[CustCategoryId]
			,[VatRate]
			,[Remark]
			,[AddressCode]
			,[PlantCode]
			,@UserName
			FROM [CustomerImport] WHERE AutoId = @AutoId
		END
		FETCH NEXT FROM iCursor INTO @AutoId
		, @Code
		, @Name
		, @Code2
		, @Code3
		, @Contact
		, @Address
		, @City
		, @State
		, @Country
		, @ZIPCode
		, @Phone
		, @Mobile
		, @Fax
		, @Email
		, @PaymentTermId
		, @CurrencyId
		, @ShipmentModeId
		, @PortLoadId
		, @PortDischargeId
		, @LocationCode
		, @CustCategoryId
		, @VatRate
		, @Remark
		, @AddressCode
		, @PlantCode
	END
	CLOSE iCursor
	DEALLOCATE icursor

	--Insert to CustomerLog
	INSERT INTO [dbo].[CustomerLog] 
	([Code]
	,[Name]
	,[Code2]
	,[Code3]
	,[Contact]
	,[Address]
	,[City]
	,[State]
	,[Country]
	,[ZIPCode]
	,[Phone]
	,[Mobile]
	,[Fax]
	,[Email]
	,[PaymentTermId]
	,[CurrencyId]
	,[ShipmentModeId]
	,[PortLoadId]
	,[PortDischargeId]
	,[LocationCode]
	,[CustCategoryId]
	,[VatRate]
	,[Remark]
	,[AddressCode]
	,[PlantCode]
	,[ExecuteBy])
	SELECT [Code]
	,[Name]
	,[Code2]
	,[Code3]
	,[Contact]
	,[Address]
	,[City]
	,[State]
	,[Country]
	,[ZIPCode]
	,[Phone]
	,[Mobile]
	,[Fax]
	,[Email]
	,[PaymentTermId]
	,[CurrencyId]
	,[ShipmentModeId]
	,[PortLoadId]
	,[PortDischargeId]
	,[LocationCode]
	,[CustCategoryId]
	,[VatRate]
	,[Remark]
	,[AddressCode]
	,[PlantCode]
	,@UserName
	FROM [CustomerImport]

	--Delete MaterialNumberImport
	
	IF(SELECT COUNT(1) FROM CustomerImport WHERE [Status] = 'Error') = 0
	BEGIN
		TRUNCATE TABLE CustomerImport
		SELECT 'OK'
	END
	ELSE
	BEGIN
		DELETE CustomerImport WHERE [Status] IS NULL
		SELECT 'FAIL'
	END
END
