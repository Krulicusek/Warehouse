--Usun procedure
DROP PROCEDURE dbo.spTowary_Dodaj;

--Utworz Procedure		Dodaj Ilosc towaru do towaru o danym ID. parametry (@ID_Towaru, @Ilosc)
CREATE PROCEDURE dbo.spTowary_Dodaj
	@ID_Towaru int,
	@Ilosc int
AS
BEGIN	--Sprawdzanie czy istnieje Zamowienie o podanym ID_Towaru
IF (EXISTS(SELECT * FROM dbo.Towary WHERE ID_Towaru = @ID_Towaru))
	BEGIN
		--Obliczanie sumy
		DECLARE @Suma int;
		DECLARE @Dotychczasowa_Ilosc_Towarow  int;
		SET @Dotychczasowa_Ilosc_Towarow = (SELECT Ilosc_Dostepnych From dbo.Towary WHERE ID_Towaru = @ID_Towaru);
		SET @Suma = @Dotychczasowa_Ilosc_Towarow + @Ilosc;
			UPDATE dbo.Towary SET Ilosc_Dostepnych = @Suma WHERE ID_Towaru = @ID_Towaru;
		RETURN 1;
	END
	--Komunikat w razie nie znalezienia danych dla @ID_Towaru
ElSE
	BEGIN
		PRINT 'ERROR NO RECORDS FOUND AT @ID_Towaru';
		RETURN 0;
	END
END
GO