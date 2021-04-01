--Usun procedure

DROP PROCEDURE dbo.spTowary_Edytuj
--Utworz Procedure	Edycja wszystkich atrybutów towaru o danym ID_Towaru
CREATE PROCEDURE dbo.spTowary_Edytuj
@ID_Towaru int,
@Nazwa_Towaru nvarchar(30),
@Data_Gwarancji date,
@Typ_Towaru nvarchar(30),
@Ilosc_Dostepnych int
AS
BEGIN
IF (EXISTS(SELECT * FROM dbo.Towary WHERE ID_Towaru = @ID_Towaru))
	BEGIN
		UPDATE dbo.Towary  SET Nazwa_Towaru = @Nazwa_Towaru, Data_Gwarancji = @Data_Gwarancji, Typ_Towaru = @Typ_Towaru, Ilosc_Dostepnych=@Ilosc_Dostepnych
		WHERE ID_Towaru = @ID_Towaru;
	END
	--Komunikat w razie nie znalezienia danych dla @ID_Towaru
ElSE PRINT 'ERROR NO RECORDS FOUND AT @ID_Towaru';
END
GO
