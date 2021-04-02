

			--Usuwanie tabeli

DROP TABLE dbo.Zamowienia;
DROP TABLE dbo.Towary;

			--Tworzenie tabeli

CREATE TABLE Towary (
ID_Towaru int IDENTITY(1,1) PRIMARY KEY,
Nazwa_Towaru nvarchar(30),
Data_Gwarancji date,
Typ_Towaru nvarchar(30),
Ilosc_Dostepnych int,
Ilosc_Zarezerwowanych int
);

CREATE TABLE Zamowienia(
ID_Zamowienia int IDENTITY(1,1) PRIMARY KEY,
ID_Towaru int FOREIGN KEY REFERENCES Towary(ID_Towaru),
Ilosc int,
Data_Zamowienia date,
Imie nvarchar(30),
Nazwisko nvarchar(30),
Adres nvarchar(30),
Dostawa varchar(30),
Data_Realizacji date
);

								--Wprowadzanie testowych danych do tabeli 
INSERT INTO Towary VALUES ('mlotek','2024-03-15','narzedzia',320,100);
INSERT INTO Towary VALUES ('noz','2024-03-15','narzedzia',210,100);
INSERT INTO Towary VALUES ('wiertarka','2024-03-15','narzedzia',350,100);
INSERT INTO Towary VALUES ('lody waniliowe pyszne kolorowe','2024-03-15','czysta slodycz', 350,150);
INSERT INTO Towary VALUES ('sorbet','2024-03-15','czysta slodycz', 150,20);
INSERT INTO Towary VALUES ('sniezka','2024-03-15','czysta slodycz', 150,100);

INSERT INTO Zamowienia VALUES (2,23,'2024-03-15','andrzej','Kubica','adres','kurier', null);
INSERT INTO Zamowienia VALUES (3,11,'2024-03-15','jakub','weg','adres','kurier', null);
INSERT INTO Zamowienia VALUES (4,13,'2024-03-15','jakub','weg','adres','kurier', null);
INSERT INTO Zamowienia VALUES (5,20,'2024-03-15','jakub','weg','adres','kurier', null);



						-- Wyswietl wszystko co w tabelach
SELECT * FROM Zamowienia;
SELECT * FROM Towary;


														--PROCEDURY

--Dodaj zamowienia
-- (jako parametr przyjmuje @ID_Towaru,	@Ilosc, @Imie, @Nazwisko, @Adres,	@Dostawa)
EXEC dbo.spZamowienia_Dodaj 4,140,'jakub','weg','adres','kurier'

-- Usun zamowienia ( Przyjmuje parametr @ID_Zamowienia)
EXEC dbo.spZamowienia_Usun 5

-- Realizuj zamowienia ( przyjmuje jako parametr @ID_Zamowienia)
EXEC dbo.spZamowienia_Realizuj 2

-- Dodaj Ilosc towaru do towaru o danym ID. parametry (@ID_Towaru, @Ilosc)
EXEC dbo.spTowary_Dodaj 1,80

--Edycja atrybutów towaru o danym ID_Towaru (@ID_Towaru, @Nazwa_Towaru, @Data_Gwarancji, @Typ_Towaru)
EXEC dbo.spTowary_Edytuj 1,'ogryzek','2024-03-15','smieci',30 

 --     Umozliwia podglad towarow podajac parametry ID_Towaru oraz Nazwa_Towaru
 --    (podglad obejmuje sume wyszukiwan po obu parametrach. W niechcianym polu wstawic parametr = null)
EXEC dbo.spTowary_Podglad null, null

 --     Umozliwia podglad towarow dostepnych. Zwraca wszystkie towary ktorych ilosc jest wieksza niz 0
EXEC dbo.spTowary_Dostepne
	--Umozliwia usuwanie Towaru  o danym ID_Towaru pod warunkiem, ze nie istnieje na niego zamowienie
EXEC dbo.spTowary_Usun 1

EXEC dbo.spTowary_Nowy 'ogryzek','2042-03-11','smieci',200

EXEC dbo.spZamowienia_Podglad null, null, ''

--tworze nowa role oraz nadaje jej mozliwosc uzywania stored procedures

CREATE ROLE dbStoredProceduresOnly;
GRANT EXECUTE TO dbStoredProceduresOnly;


