using System;
namespace WarehouseLibrary
{
    public class TowaryModel
    {
        public int ID_Towaru { get; set; }
        public string Nazwa_Towaru { get; set; }
        public DateTime Data_Gwarancji { get; set; }
        public string Typ_Towaru { get; set; }
        public int Ilosc_Dostepnych { get; set; }
        public int Ilosc_Zarezerwowanych { get; set; }
        public TowaryModel()
        {

        }
        


    }
}
