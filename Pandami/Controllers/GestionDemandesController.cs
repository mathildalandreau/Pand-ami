using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pandami.Controllers
{
    public class GestionDemandesController : Controller
    {
        // GET: GestionDemandes
        public ActionResult Demandedeservice()
        {
            return View();
        }

        public ActionResult Suividesdemandes()
        {
            return View();
        }

        public ActionResult Recherchedeservice()
        {
            return View();
        }
    }
}