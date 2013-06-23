﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class PalestranteController : Controller
    {
        //
        // GET: /Palestrante/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Palestrante/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Palestrante/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Palestrante/Create

        [HttpPost]
        public ActionResult Create(Palestrante palestrante)
        {
            try
            {
                var teste = ModelState.IsValid;
                //salva no banco
                ViewBag.Mensagem = "Sucesso " + palestrante.Nome;
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Palestrante/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Palestrante/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Palestrante/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Palestrante/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
