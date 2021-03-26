using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary
{
    public class RealizujModel
    {
        public int ID_Zamowienia { get; set; }
       public  RealizujModel()
        {

        }
        public RealizujModel(string idString)
        {
            int id = 0;
            int.TryParse(idString, out id);
            ID_Zamowienia = id;
        }
    }
}
