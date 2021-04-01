
--Usun procedure

DROP PROCEDURE dbo.spZamowienia_Dodaj;

--Utworz procedure

CREATE PROCEDURE dbo.spZamowienia_Dodaj
--deklaracja parametrow
	@ID_Towaru int,
	@Ilosc int,
	@Imie nvarchar(30),
	@Nazwisko nvarchar(30),
	@Adres nvarchar (30),
	@Dostawa varchar(30)
	AS
	BEGIN
	IF (EXISTS(SELECT*FROM dbo.Towary WHERE @ID_Towaru = @ID_Towaru))
		BEGIN
		SET NOCOUNT ON;	--nie wyswietlamy komunikatu "rows affected"
		DECLARE @Data_Zamowienia date;
		DECLARE @Ilosc_Dostepnych  int;
		DECLARE @Roznica int;
		DECLARE @Ilosc_Zarezerwowanych int;
		DECLARE @Suma_Zarezerwowanych int;

		SET @Data_Zamowienia = GETDATE();

		SET @Ilosc_Dostepnych =  (SELECT Ilosc_Dostepnych FROM dbo.Towary WHERE ID_Towaru = @ID_Towaru);

		SET @Ilosc_Zarezerwowanych = (SELECT Ilosc_Zarezerwowanych FROM dbo.Towary WHERE ID_Towaru = @ID_Towaru);

		SET @Roznica = (@Ilosc_Dostepnych  - @Ilosc)

		SET @Suma_Zarezerwowanych = @Ilosc_Zarezerwowanych + @Ilosc
		IF (@Roznica >= 0) 
			BEGIN

			INSERT INTO dbo.Zamowienia (ID_Towaru,Ilosc, Data_Zamowienia, Imie, Nazwisko, Adres, Dostawa)
			VALUES (@ID_Towaru,	@Ilosc,	@Data_Zamowienia, @Imie, @Nazwisko, @Adres,	@Dostawa);

			UPDATE dbo.Towary SET Ilosc_Dostepnych = @Roznica, Ilosc_Zarezerwowanych = @Suma_Zarezerwowanych WHERE ID_Towaru = @ID_Towaru
	
			END ELSE PRINT 'Ilosc_Dostepnych towarow nie wystarczajaca na zamowienie'
		END
	END
	GO