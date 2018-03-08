﻿using ClassLibrary1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio3.Controllers
{
    public class AVLTreeController : Controller
    {
        // GET: AVLTree
        public ActionResult Index()
        {
            return View();
        }

        // GET: AVLTree/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AVLTree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AVLTree/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AVLTree/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AVLTree/Edit/5
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

        // GET: AVLTree/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AVLTree/Delete/5
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

        /////////////////////////GGGGGGGGGGGGGGGGGGGGG////////////////////

        public ActionResult AVLTree()
        {
            var path = @"C:\Users\denni\Downloads\URL\Estructura de Datos I\Laboratorio\Laboratorio 2\datacadenas.json";
            var contenido = System.IO.File.ReadAllText(path);
            var arbol = JsonConvert.DeserializeObject<AVLTree<string>>(contenido);

            var cadena = JsonConvert.SerializeObject(arbol);
            TempData["Arbol"] = cadena;


            return View();
        }

    }
}
