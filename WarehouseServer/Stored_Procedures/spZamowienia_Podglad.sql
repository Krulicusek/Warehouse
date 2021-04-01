--Usun procedure

DROP PROCEDURE dbo.spZamowienia_Podglad
--Utworz Procedure	
	--Umozliwia Podglad Zamowien
	--Mozliwosc wyszukiwania po ID_Zamowienia , Data_Zamowienia, Data_Realizacji , Nazwisko zamawiajacego oraz Adres
CREATE PROCEDURE dbo.spZamowienia_Podglad
@ID_Zamowienia int,
@Nazwisko nvarchar(30),
@Adres nvarchar(30)
AS
BEGIN
SET NOCOUNT ON;

	BEGIN
	SELECT * FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia
	OR Nazwisko LIKE '%' + @Nazwisko + '%' OR Adres LIKE '%' +@Adres + '%';
	END	
END
GO

