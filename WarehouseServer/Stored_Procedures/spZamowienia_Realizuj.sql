
		--Usun procedure

DROP PROCEDURE dbo.spZamowienia_Realizuj 

		--Utworz procedure
CREATE PROCEDURE dbo.spZamowienia_Realizuj
	@ID_Zamowienia int	
AS
BEGIN
IF (EXISTS(SELECT*FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia))
BEGIN
	SET NOCOUNT ON;	--nie wyswietlamy komunikatu "rows affected"
	--deklaracja zmiennych
	DECLARE @Data_Realizacji date;
	DECLARE @Ilosc_Zamowionych int;
	DECLARE @ID_Towaru int;
	DECLARE @Ilosc_Zarezerwowanych int;
	DECLARE @Roznica int;
	-- zmienna @Data_Realizacji to aktualna data systemu na ktorym jest baza danych
	SET @Data_Realizacji = GETDATE();

	-- przypisanie zmiennej ID Towaru ktorego dotyczylo zamowienia
	SET @ID_Towaru = (SELECT ID_Towaru FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia);
	
	--przypisanie zmiennym ilosci towaru z magazynu oraz ilosci zamowionych
	SET @Ilosc_Zamowionych =  (SELECT Ilosc FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia);

	SET @Ilosc_Zarezerwowanych=  (SELECT Ilosc_Zarezerwowanych FROM dbo.Towary WHERE ID_Towaru = @ID_Towaru);
	--Obliczenie roznicy w ilosci
	SET @Roznica = @Ilosc_Zarezerwowanych - @Ilosc_Zamowionych;
	-- Sprawdzenie czy roznica nie jest mniejsza niz 0 (towaru nie ma na magazynie)
	IF (@Roznica >= 0)
	BEGIN

	UPDATE	dbo.Zamowienia SET Data_Realizacji = @Data_Realizacji WHERE ID_Zamowienia = @ID_Zamowienia;

	UPDATE  dbo.Towary SET Ilosc_Zarezerwowanych = @Roznica WHERE ID_Towaru=@ID_Towaru;
	END
	ELSE PRINT 'NIE MOZNA ZREALIZOWAC ZAMOWIENIA PONIEWAZ ILOSC ZAREZERWOWANYCH ODJAC ILOSC ZAMOWIONYCH JEST MNIEJSZA NIZ ZERO'
	
END
ELSE PRINT 'ERROR NO RECORDS FOUND AT @ID_Zamowienia';
END	
GO
