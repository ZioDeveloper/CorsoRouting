using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorsoRouting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return base.File("Assic.pdf", "application/pdf");
            //return base.JavaScript("alert('Hello World');");
            //return base.Redirect("Prodotti/dettaglio/34");
            return View();
        }


        public ContentResult Benvenuto ()
        {
            return Content ( "Benvenuto utente.");
        }
    }
}