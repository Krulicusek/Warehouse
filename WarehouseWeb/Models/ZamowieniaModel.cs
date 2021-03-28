
using System;

namespace WarehouseWeb
{
    public class ZamowieniaModel
    {
      
        public int ID_Towaru { get; set; }
        public int Ilosc { get; set; }       
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Dostawa { get; set; }
        

        public ZamowieniaModel()
        {

        }
    }
}
