using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseWeb
{
   public  class TowaryDostepneModel
    {
        public int ID_Towaru { get; set; }
        public string Nazwa_Towaru{ get; set; }
        public DateTime Data_Gwarancji { get; set; }
        public int  Ilosc_Dostepnych { get; set; }
        public TowaryDostepneModel()
        {

        }
    }
}
