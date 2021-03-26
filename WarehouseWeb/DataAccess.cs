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
                return connection.Query<TowaryModel>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}