using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarehouseWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListTowary()
        {
            List<TowaryModel> towary = new List<TowaryModel>();
            DataAccess db = new DataAccess();
            towary = db.GetTowaryModel();
            return View();
        }
  
    }
}