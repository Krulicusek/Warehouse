using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Properties
{
    public class IloscModel
    {
        public int ID_Towaru { get; set; }
        public int Ilosc {get; set;}

        public IloscModel()
        {

        }
        public IloscModel(string idString, string iloscString)
        {
            //zamiana parametrow podanych jako string, na int, na wszelki wypadek wczesniej przypisuje do zmiennych 0 gdyby konwersja nie udala sie

            int id = 0;
            int.TryParse(idString, out id);
            ID_Towaru = id;
            int iloscNumber = 0;
            int.TryParse(iloscString, out iloscNumber);
            Ilosc = iloscNumber;
        }

    }
}
