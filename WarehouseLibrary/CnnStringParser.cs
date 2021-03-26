using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WarehouseLibrary
{
    public static class CnnStringParser
    {
        public static string CnnValue(string name)
        {
            //pobieram odpowiedniego connection stringa z pliku app.config i zwracam go
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
