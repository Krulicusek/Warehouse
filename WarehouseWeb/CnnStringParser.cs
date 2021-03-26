using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WarehouseWeb
{
    public static class CnnStringParser
    {
        public static string CnnValue(string name)
        {
            //pobieram odpowiedniego connection stringa z pliku web.config i zwracam go
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
