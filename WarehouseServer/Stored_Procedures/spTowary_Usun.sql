--Usun procedure

DROP PROCEDURE dbo.spTowary_Usun
--Utworz Procedure	
	--Umozliwia usuwanie Towaru  o danym ID_Towaru pod warunkiem, ze nie istnieje na niego zamowienie
CREATE PROCEDURE dbo.spTowary_Usun
@ID_Towaru int
AS
BEGIN
SET NOCOUNT ON; 
IF( NOT EXISTS (SELECT * FROM dbo.Zamowienia WHERE ID_Towaru = @ID_Towaru) 
	AND EXISTS (SELECT*FROM dbo.Towary WHERE ID_Towaru=@ID_Towaru))
	BEGIN
	DELETE FROM Towary WHERE ID_Towaru = @ID_Towaru;
	RETURN 1
	END
	ELSE 
	BEGIN
	PRINT 'Nie mozna usunac Towaru! Produnkt o podanym ID_Towaru nie istnieje, badz istnieje na niego zamowienie.';
	RETURN 0
	END
END
GO
