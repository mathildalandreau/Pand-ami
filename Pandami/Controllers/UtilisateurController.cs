using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pandami.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: Utilisateur
        public ActionResult Utilisateur()
        {
            return View();
        }

        public ActionResult Deconnexionview()
        {
            return View();
        }
    }
}