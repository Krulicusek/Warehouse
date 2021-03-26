using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Properties
{
  public class NowyModel
    {
        public string NazwaTowaru { get; set; }
        public DateTime DataGwarancji { get; set; }
        public string TypTowaru  { get; set; }
        public int Ilosc { get; set; }

        public NowyModel()
        {

        }
        public NowyModel(string nazwaTowaru, DateTime dataGwarancji, string typTowaru, string ilosc)
        {
            NazwaTowaru = nazwaTowaru;
            DataGwarancji = dataGwarancji;
            TypTowaru = typTowaru;
            //zamiana parametru podanego jako string, na int, na wszelki wypadek wczesniej przypisuje do zmiennych 0 gdyby konwersja nie udala sie
            int iloscNumber = 0;
            int.TryParse(ilosc, out iloscNumber);
            Ilosc = iloscNumber;
        }
    }
}
