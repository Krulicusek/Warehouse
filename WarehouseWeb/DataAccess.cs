using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
namespace WarehouseWeb
{
    public class DataAccess
    {
        public List<TowaryModel> GetTowaryModel(int? id, string nazwaTowaru)
        {
            //zamiana parametrow podanych jako string, na int, na wszelki wypadek wczesniej przypisuje do zmiennych 0 gdyby konwersja nie udala sie
            
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku web.config
            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {
                // deklaruje dynamiczne parametry, oraz nazwe procedury 
                var procedure = "[dbo].[spTowary_Podglad]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID_Towaru", id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Nazwa_Towaru", nazwaTowaru, DbType.String, ParameterDirection.Input);

                // wykonuje procedure, wynik castuje jako TowaryModel i robie z niego liste
                return connection.Query<TowaryModel>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public bool SendZamowienie(int id, int ilosc, string imie, string nazwisko, string adres, string dostawa)
        {
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku web.config
           
            
                using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
                {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                    var procedure = "[dbo].[spZamowienia_Dodaj]";
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ID_Towaru", id, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@Ilosc", ilosc, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@Imie", imie, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Nazwisko", nazwisko, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Adres", adres, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Dostawa", dostawa, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Return", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
                //wykonuje procedure
                connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
                //Checking status of Stored Procedure Call
                int returnValue = parameters.Get<int>("@Return");
                if (returnValue == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

        }
            }
        




    }
}