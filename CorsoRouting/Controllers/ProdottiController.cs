using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorsoRouting.Controllers
{
    public class ProdottiController : Controller
    {
        // GET: Prodotti
        public ActionResult Dettaglio(int idP,string Descrizione,DateTime dataVendita )
        {

            ViewBag.ProdID   = idP;
            ViewBag.PrdoDescr = Descrizione;
            ViewBag.Data = dataVendita.ToShortDateString();
            return View();
        }

        [OutputCache(Duration = 15 )]
        public string Orario()
        {
            return DateTime.Now.ToString("T");
        }

        [Authorize]
        public ActionResult ListAccounts()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Messaggio = "Qualche messaggio inutile...";
            return View();
        }

        public ActionResult About2()
        {
            ViewBag.Messaggio = "Qualche messaggio inutile...";
            return View();
        }

        public ActionResult Index()
        {
            //return base.File("Test.txt", "text/plain");
            return View();

        }
    }
}