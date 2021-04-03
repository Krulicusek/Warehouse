using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarehouseWeb.Controllers
{
    public class HomeController : Controller
    {
       
        private DataAccess db = new DataAccess();
        public ActionResult Index(int? id, string nazwa)
        {
            List<TowaryModel> towary = new List<TowaryModel>();
            // w wypadku nie podania parametrów, wyświetlam wszystkie wyniki
            if (nazwa == null && id == null)
            {
                towary = db.GetTowaryModel(id, "");
            }     // jezeli podano któryś z parametrów to wyszukuje po nich     
            else
            {
                towary = db.GetTowaryModel(id, nazwa);
            }
            // można zapisać w jednej linijce, ale moim zdaniem troche utrudnia to rozczytanie kodu dlatego tutaj jak i w innych fragmentach solucji zostawiam tradycyjnego if else
            //towary = (nazwa == null && id == null) ? db.GetTowaryModel(id, "") : db.GetTowaryModel(id, nazwa);

            return View(towary);
        }

        public ActionResult Zamow()
        {          
            return View();
        }
        [HttpPost]
     public ActionResult Zamow(int id, ZamowieniaModel zamowienia)
        {
            // jezeli wprowadzono poprawne dane 
            if (ModelState.IsValid)
            {       // wysylam pobrane z form wartosci do bazy danych  
                if (db.SendZamowienie(id, zamowienia.Ilosc, zamowienia.Imie, zamowienia.Nazwisko, zamowienia.Adres, zamowienia.Dostawa))
                {
                    return RedirectToAction("Succes");
                }
                //else
                //{
                //    return 
                //}
            
                
            }
            return View(zamowienia);
        }
        public ActionResult Succes()
        {
            return View();
        }

    }
}