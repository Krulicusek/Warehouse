--Usun procedure

DROP PROCEDURE dbo.spTowary_Usun
--Utworz Procedure	
	--Umozliwia usuwanie Towaru  o danym ID_Towaru pod warunkiem, ze nie istnieje na niego zamowienie
CREATE PROCEDURE dbo.spTowary_Usun
@ID_Towaru int
AS
BEGIN
SET NOCOUNT ON; 
IF( NOT EXISTS (SELECT * FROM Zamowienia WHERE ID_Towaru = @ID_Towaru))
	BEGIN
	DELETE FROM Towary WHERE ID_Towaru = @ID_Towaru;
	END
	ELSE 
	PRINT 'NIE MOZNA USUNAC TOWARU, NA KTORY ISTNIEJE ZAMOWIENIE!';
END
GO
