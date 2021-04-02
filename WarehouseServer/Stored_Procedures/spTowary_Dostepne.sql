		
		--Usun procedure

DROP PROCEDURE dbo.spTowary_Dostepne
 --		Utworz Procedure	
 --     Umozliwia podglad towarow dostepnych. Zwraca wszystkie towary ktorych ilosc jest wieksza niz 0
CREATE PROCEDURE dbo.spTowary_Dostepne
AS
BEGIN
SET NOCOUNT ON;	
		SELECT ID_Towaru,Nazwa_Towaru,Data_Gwarancji,Ilosc_Dostepnych FROM  dbo.Towary WHERE Ilosc_Dostepnych > 0
END
GO
