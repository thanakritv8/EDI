USE [ROKI_EDI]
GO
/****** Object:  StoredProcedure [dbo].[sp_MaterialNumberImport]    Script Date: 10-Oct-2018 10:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[sp_MaterialNumberImport]
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	--By 1256 20181010
	UPDATE [MaterialNumberImport] SET [Status] = 'Error' WHERE SoldtoParty IS NULL OR ShiptoParty IS NULL OR CustomerItemNumber IS NULL OR MaterialNumber IS NULL
	DECLARE @AutoId DECIMAL(18,0)
	, @SoldtoParty NVARCHAR(255)
	, @ShiptoParty NVARCHAR(255)
	, @CustomerItemNumber NVARCHAR(255)
	, @MassPartsIDFlag NVARCHAR(255)
    , @ExpansionKey1 NVARCHAR(255)
    , @ExpansionKey2 NVARCHAR(255)
    , @ExpansionKey3 NVARCHAR(255)
    , @VaridityDateTo NVARCHAR(255)
    , @ValiditydateFrom NVARCHAR(255)
    , @PLANT NVARCHAR(255)
    , @MaterialNumber NVARCHAR(255)
    , @UnitCode NVARCHAR(50)
	DECLARE iCursor CURSOR FOR
	SELECT AutoId,SoldtoParty,ShiptoParty,CustomerItemNumber,MassPartsIDFlag
    ,[ExpansionKey1],[ExpansionKey2],[ExpansionKey3],[VaridityDateTo]
    ,[ValiditydateFrom],[PLANT],[MaterialNumber],[UnitCode]
	FROM [MaterialNumberImport]
	OPEN iCursor
	FETCH NEXT FROM iCursor INTO @AutoId
	, @SoldtoParty
	, @ShiptoParty
	, @CustomerItemNumber
	, @MassPartsIDFlag
    , @ExpansionKey1
    , @ExpansionKey2
    , @ExpansionKey3
    , @VaridityDateTo
    , @ValiditydateFrom
    , @PLANT
    , @MaterialNumber
    , @UnitCode
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF EXISTS(SELECT 1 FROM MaterialNumber WHERE SoldtoParty = @SoldtoParty AND ShiptoParty = @ShiptoParty AND CustomerItemNumber = @CustomerItemNumber AND MaterialNumber = @MaterialNumber)
		BEGIN
			--Update to MaterialNumber
			UPDATE MaterialNumber SET MassPartsIDFlag = @MassPartsIDFlag
			, ExpansionKey1 = @ExpansionKey1
			, ExpansionKey2 = @ExpansionKey2
			, ExpansionKey3 = @ExpansionKey3
			, VaridityDateTo = @VaridityDateTo
			, ValiditydateFrom = @ValiditydateFrom
			, PLANT = @PLANT
			, UnitCode = @UnitCode
			, UpdateBy = @UserName
			, UpdateDate = GETDATE()
			WHERE SoldtoParty = @SoldtoParty AND ShiptoParty = @ShiptoParty AND CustomerItemNumber = @CustomerItemNumber AND MaterialNumber = @MaterialNumber
		END
		ELSE
		BEGIN
			--Insert to MaterialNumber
			INSERT INTO [dbo].[MaterialNumber] 
			(SoldtoParty,ShiptoParty,CustomerItemNumber,MassPartsIDFlag
			,ExpansionKey1,ExpansionKey2,ExpansionKey3,VaridityDateTo
			,ValiditydateFrom,PLANT,MaterialNumber,UnitCode,CreateBy)
			SELECT SoldtoParty,ShiptoParty,CustomerItemNumber,MassPartsIDFlag
			,ExpansionKey1,ExpansionKey2,ExpansionKey3,VaridityDateTo
			,ValiditydateFrom,PLANT,MaterialNumber,UnitCode,@UserName
			FROM [MaterialNumberImport] WHERE AutoId = @AutoId
		END
		FETCH NEXT FROM iCursor INTO @AutoId
		, @SoldtoParty
		, @ShiptoParty
		, @CustomerItemNumber
		, @MassPartsIDFlag
		, @ExpansionKey1
		, @ExpansionKey2
		, @ExpansionKey3
		, @VaridityDateTo
		, @ValiditydateFrom
		, @PLANT
		, @MaterialNumber
		, @UnitCode
	END
	CLOSE iCursor
	DEALLOCATE icursor

	--Insert to MaterialNumberLog
	INSERT INTO [dbo].[MaterialNumberLog] 
	(SoldtoParty,ShiptoParty,CustomerItemNumber,MassPartsIDFlag
	,ExpansionKey1,ExpansionKey2,ExpansionKey3,VaridityDateTo
	,ValiditydateFrom,PLANT,MaterialNumber,UnitCode,[Status],ExecuteBy)
	SELECT SoldtoParty,ShiptoParty,CustomerItemNumber,MassPartsIDFlag
	,ExpansionKey1,ExpansionKey2,ExpansionKey3,VaridityDateTo
	,ValiditydateFrom,PLANT,MaterialNumber,UnitCode,[Status],@UserName
	FROM [MaterialNumberImport]

	--Delete MaterialNumberImport
	
	IF(SELECT COUNT(1) FROM MaterialNumberImport WHERE [Status] = 'Error') = 0
	BEGIN
		TRUNCATE TABLE MaterialNumberImport
		SELECT 'OK'
	END
	ELSE
	BEGIN
		DELETE MaterialNumberImport WHERE [Status] IS NULL
		SELECT 'FAIL'
	END
END
