using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary
{
    public class EdytujModel
    {
        public int ID_Towaru { get; set; }
        public string Nazwa_Towaru { get; set; }
        public DateTime Data_Gwarancji { get; set; }
        public string Typ_Towaru { get; set; }
        public int Ilosc { get; set; }

        public EdytujModel(string idString, string nazwaTowaru, DateTime dataGwarancji, string typTowaru, string iloscString)
        {
            int id = 0;
            int.TryParse(idString, out id);
            ID_Towaru = id;
            int iloscNumber = 0;
            int.TryParse(iloscString, out iloscNumber);
            Ilosc = iloscNumber;
            Nazwa_Towaru = nazwaTowaru;
            Data_Gwarancji = dataGwarancji;
            Typ_Towaru = typTowaru;
        }


    }
}
