using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary
{
    public class UsunModel
    {
        public int ID_Towaru { get; set; }




        public UsunModel()
        {

        }
        public UsunModel(string idString)
        {
            int id = 0;
            int.TryParse(idString, out id);
            ID_Towaru = id;
        }

    }
   
}
