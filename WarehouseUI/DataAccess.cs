using System;
using System.Collections.Generic;
using System.Text;
using WarehouseLibrary.Properties;
using Dapper;
using System.Data;
using System.Linq;
using WarehouseLibrary;
using System.Data.SqlClient;

namespace WarehouseUI
{
public  class DataAccess
    {
        public void DodajIlosc (int id, int ilosc)
        {   
           
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                var procedure = "[dbo].[spTowary_Dodaj]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Towaru", id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Ilosc", ilosc, DbType.Int32, ParameterDirection.Input);
                //wykonuje procedure
               connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void DodajNowy(string nazwaTowaru, DateTime dataGwarancji, string typTowaru, int ilosc)
        {
            
            // otwieram polaczenie z baza danych. dzieki "using" upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                
               
                var procedure = "[dbo].[spTowary_Nowy]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Nazwa_Towaru", nazwaTowaru, DbType.String, ParameterDirection.Input);
                parameters.Add("@Data_Gwarancji", dataGwarancji, DbType.Date, ParameterDirection.Input);
                parameters.Add("@Typ_Towaru", typTowaru, DbType.String, ParameterDirection.Input);
                parameters.Add("@Ilosc_Dostepnych", ilosc, DbType.Int32, ParameterDirection.Input);
                //wykonuje procedure
                connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void Edytuj(int id, string nazwaTowaru, DateTime dataGwarancji, string typTowaru, int ilosc)
        {
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                var procedure = "[dbo].[spTowary_Edytuj]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Towaru", id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Nazwa_Towaru", nazwaTowaru, DbType.String, ParameterDirection.Input);
                parameters.Add("@Data_Gwarancji", dataGwarancji, DbType.Date, ParameterDirection.Input);
                parameters.Add("@Typ_Towaru", typTowaru, DbType.String, ParameterDirection.Input);
                parameters.Add("@Ilosc_Dostepnych", ilosc, DbType.Int32, ParameterDirection.Input);
                //wykonuje procedure
                connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public bool UsunTowar(int id)
        {
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                var procedure = "[dbo].[spTowary_Usun]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Towaru", id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Return", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
                //wykonuje procedure
                connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
                int returnValue = parameters.Get<int>("@Return");
                if (returnValue == 0)
                {
                    return false;
                }
                else return true;
            }
        }
        public List<TowaryModel> GetTowaryModel(string idString, string nazwaTowaru)
        {   
            //zamiana parametrow podanych jako string, na int, na wszelki wypadek wczesniej przypisuje do zmiennych 0 gdyby konwersja nie udala sie
            int id = 0;
            int.TryParse(idString, out id);
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {
                // deklaruje dynamiczne parametry, oraz nazwe procedury 
                var procedure = "[dbo].[spTowary_Podglad]";               
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Towaru", id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Nazwa_Towaru", nazwaTowaru, DbType.String, ParameterDirection.Input);              

                // wykonuje procedure, wynik castuje jako TowaryModel i robie z niego liste
                return connection.Query<TowaryModel>(procedure,parameters,  commandType: CommandType.StoredProcedure).ToList();
            }
        }




        public List<ZamowieniaModel> GetZamowieniaModel(string idString, string nazwisko, string adres)
        {   //zamiana parametrow podanych jako string, na int, na wszelki wypadek wczesniej przypisuje do zmiennych 0 gdyby konwersja nie udala sie
            int id = 0;
            int.TryParse(idString, out id);
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures"))) {

                // deklaruje dynamiczne parametry, oraz nazwe procedury 
                var procedure = "[dbo].[spZamowienia_Podglad]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Zamowienia", id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Nazwisko", nazwisko, DbType.String, ParameterDirection.Input);               
                parameters.Add("@Adres", adres, DbType.String, ParameterDirection.Input);

                // wykonuje procedure, wynik castuje jako ZamowieniaModel i robie z niego liste
                return connection.Query<ZamowieniaModel>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public void Realizuj(int id)
        {
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                var procedure = "[dbo].[spZamowienia_Realizuj]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Zamowienia", id, DbType.Int32, ParameterDirection.Input);
                //wykonuje procedure
                connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
