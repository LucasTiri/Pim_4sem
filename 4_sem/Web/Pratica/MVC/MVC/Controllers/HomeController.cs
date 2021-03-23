using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult IncluirUser()
        {
            return View();
        }
        public ActionResult Usuario()
        {
            return View();
        }
        public ActionResult Usuario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Usuario(Usuario _usuario)
        {
            if (ModelState.IsValid)
            {
                using (DSIEntities dc = new DSIEntities())
                {
                    dc.Usuarios.Add(_usuario);
                    dc.SaveChanges();
                    ModelState.Clear();
                    _usuario = null;
                    //Desafio implmentar mensagem de sucesso!
                    //ViewBag.Message = "Usuário registrado com sucesso.";
                }
            }
            return View(_usuario);
        }
    }
}