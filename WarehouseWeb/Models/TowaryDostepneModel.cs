using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary
{
   public  class TowaryDostepneModel
    {
        public int ID { get; set; }
        public string Nazwa{ get; set; }
        public DateTime Data_Gwarancji { get; set; }
        public int  Ilosc { get; set; }
    }
}
