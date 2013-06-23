using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo1.Models;

namespace Demo1.Controllers
{
    public class PalestranteController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Nome = "Rodolfo";

            return  View();
        }

        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Novo(Palestrante palestrante)
        {
            if (ModelState.IsValid)
            {
                //salva o palestrante
                var teste = palestrante;
                ViewBag.Mensagem = "Criado Com Sucesso";
                ViewBag.Nome = palestrante.Nome;
                return View("Index");
            }
            return View(palestrante);
        }
    }
}
