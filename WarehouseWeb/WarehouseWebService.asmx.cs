using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using Dapper;
using Newtonsoft.Json;


namespace WarehouseWeb
{
   // Webservice for WarehouseClientUI that allows for sending order request, and getting list of warehouse items

    [WebService(Namespace = "WarehouseWebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WarehouseWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public void SendZamowienie(int id, int ilosc, string imie, string nazwisko, string adres, string dostawa)
        {
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config


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
                //wykonuje procedure
                connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        [WebMethod]
        public string GetTowary ()
        {
            // otwieram polaczenie z baza danych. dzieki "using " upewniam się, że polaczenie z baza danych bedzie prawidlowo zamkniete w razie gdyby w trakcie dzialania funkcji wystapił bład
            // za pomoca wczesniej stworzonej klasy CnnStringParser pobieram odpowiedniego connection stringa z pliku app.config


            using (IDbConnection connection = new SqlConnection(CnnStringParser.CnnValue("StoredProcedures")))
            {    // deklaruje dynamiczne parametry, oraz nazwe procedury            
                var procedure = "[dbo].[spTowary_Dostepne]";
                DynamicParameters parameters = new DynamicParameters();
                //wykonuje procedure
                List<TowaryModel> towary = new List<TowaryModel>();
                towary = connection.Query<TowaryModel>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList();
                
                return JsonConvert.SerializeObject(towary);
                
                
            }
        }





    }
}
