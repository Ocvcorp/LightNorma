﻿using LightNorma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        private LightNormaDBContext db;
        public HomeController(LightNormaDBContext context)
        {
            db=context;
        }
        public IActionResult Index()
        {
            var setsILN = db.IndustrialLightNormaSets.Include(p => p.SP52IndustrialWorkRank)
                                                    .Include(p => p.SP52IndustrialWorkSubRank)
                                                    .Include(p => p.SP52BackgroundContrast)
                                                    .Include(p => p.SP52BackgroundCharacteristic)
                                                    .Include(p => p.CombinedCommonPartIlluminance)
                                                    .Include(p => p.CombinedTotalIlluminance)
                                                    .Include(p => p.CommonIlluminance);
            return View(setsILN?.ToList());
        }

        /*
        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
