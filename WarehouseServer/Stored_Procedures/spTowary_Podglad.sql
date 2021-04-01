--Usun procedure

DROP PROCEDURE dbo.spTowary_Podglad
--Utworz Procedure	
 --     Umozliwia podglad towarow podajac parametry ID_Towaru oraz Nazwa_Towaru
 --    (podglad obejmuje sume wyszukiwan po obu parametrach. W niechcianym polu wstawic parametr = null)
 --		Mozliwosc wyszukania po czesci nazwy
CREATE PROCEDURE dbo.spTowary_Podglad
@ID_Towaru int,
@Nazwa_Towaru varchar(30)
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM dbo.Towary WHERE ID_Towaru = @ID_Towaru OR Nazwa_Towaru LIKE '%' + @Nazwa_Towaru + '%';
END
GO
