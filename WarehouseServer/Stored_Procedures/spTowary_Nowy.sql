--Usun procedure
DROP PROCEDURE dbo.spTowary_Nowy;

--Utworz Procedure		Dodaj nowy towar
CREATE PROCEDURE dbo.spTowary_Nowy	
	@Nazwa_Towaru nvarchar(30),
	@Data_Gwarancji date,
	@Typ_Towaru nvarchar(30),
	@Ilosc_Dostepnych int
AS
BEGIN
INSERT INTO dbo.Towary(Nazwa_Towaru,Data_Gwarancji,Typ_Towaru,Ilosc_Dostepnych,Ilosc_Zarezerwowanych) VALUES(@Nazwa_Towaru,@Data_Gwarancji,@Typ_Towaru,@Ilosc_Dostepnych,0);
END
GO