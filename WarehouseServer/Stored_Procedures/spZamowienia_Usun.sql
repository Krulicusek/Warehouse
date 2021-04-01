
--Usun procedure
DROP PROCEDURE dbo.spZamowienia_Usun;

--Procedura usuwa zamówiania o danym 
CREATE PROCEDURE dbo.spZamowienia_Usun
--deklaracja parametru
	@ID_Zamowienia int	
	AS	
	BEGIN
	SET NOCOUNT ON; --nie wyswietlamy komunikatu "rows affected"
	
	--Sprawdzanie czy istnieje Zamowienie o podanym ID_Zamowienia
	IF (EXISTS(SELECT*FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia))	
		BEGIN

	-- Obliczanie  sumy  @IloscTowarow i @IloscTowarow 
	DECLARE @Ilosc_Zarezerwowanych int;
	DECLARE @ID_Towaru int;
	DECLARE @Ilosc_Dostepnych int;
	DECLARE @Suma int;
	DECLARE @Roznica int;
	DECLARE @Ilosc_Zamowionych int

	--przypisywanie wartosci zmiennym, SELECT z konkretnych tabeli
	SET @ID_Towaru = (SELECT ID_Towaru FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia );

	SET @Ilosc_Zarezerwowanych = (SELECT Ilosc_Zarezerwowanych From dbo.Towary WHERE ID_Towaru = @ID_Towaru);

	SET @Ilosc_Dostepnych =  (SELECT Ilosc_Dostepnych FROM dbo.Towary WHERE ID_Towaru=@ID_Towaru);

	SET @Ilosc_Zamowionych = (SELECT Ilosc FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia)

	SET @Suma = @Ilosc_Zamowionych + @Ilosc_Dostepnych;
	
	SET @Roznica = @Ilosc_Zarezerwowanych - @Ilosc_Zamowionych;
	--Usuwanie zamowienia oraz zwracanie towaru do magazynu
	DELETE FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia;
	UPDATE dbo.Towary SET Ilosc_Dostepnych = @Suma, Ilosc_Zarezerwowanych = @Roznica WHERE ID_Towaru = @ID_Towaru;
		END

	--Komunikat w razie gdyby nie istnialo zamowienie o podanym ID_Zamowienia
	ELSE 
	PRINT 'ERROR NO RECORDS FOUND AT @ID_Zamowienia';
	END
	GO