using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using LightNorma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LightNorma.Controllers
{
    public class IlluminanceNormaController : Controller
    {
        LightNormaDBContext db;
        static bool addUpdateSwitcher; //switching between Add/Update methods
        public IlluminanceNormaController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var extractILN = db.IlluminanceNormas.Include(p => p.AreaRoomPlaces)
                                                 .Include(p => p.LightReglament)
                                                 .ToList();
            ViewBag.PublicWorkRanks = db.sp52publicWorkRanks.ToList();
            ViewBag.IndustrialWorkRanks = db.sp52industrialWorkRanks.ToList();
            ViewBag.PublicWorkSubRanks = db.sp52publicWorkSubRanks.ToList();
            ViewBag.IndustrialWorkSubRanks = db.sp52industrialWorkSubRanks.ToList();

            return View(extractILN);
        }
        [HttpGet]
        public IActionResult Create()
        {
            MultiSelectList areaPlaceCategory0 = new MultiSelectList(db.AreaPlaceCategories0, "Id", "Name");
            ViewBag.AreaPlaceCategories0 = areaPlaceCategory0;
            MultiSelectList areaRoomPlaces = new MultiSelectList(db.AreaRoomPlaces, "Id", "Name");
            ViewBag.AreaRoomPlaces = areaRoomPlaces;
            
            SelectList sP52IndustrialWorkRanks = new SelectList(db.sp52industrialWorkRanks, "Id", "Value");
            ViewBag.SP52IndustrialWorkRanks = sP52IndustrialWorkRanks;
            SelectList sP52IndustrialWorkSubRanks = new SelectList(db.sp52industrialWorkSubRanks, "Id", "Value");
            ViewBag.SP52IndustrialWorkSubRanks = sP52IndustrialWorkSubRanks;
            SelectList sP52PubliclWorkRanks = new SelectList(db.sp52backgroundContrasts, "Id", "Value");
            ViewBag.SP52PubliclWorkRanks = sP52PubliclWorkRanks;
            SelectList sP52PubliclSubWorkRanks = new SelectList(db.sp52BackgroundCharacteristics, "Id", "Value");
            ViewBag.SP52PubliclSubWorkRanks = sP52PubliclSubWorkRanks;

            /*SelectList illuminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.Illuminances = illuminances;
            SelectList combinedCommonIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.CombinedCommonIlluminances = illuminances;
            SelectList combinedLocalIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.CombinedLocalIlluminances = illuminances;*/         

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IlluminanceNorma illuminanceNorma)
        {
            if (ModelState.IsValid)
            {
                db.IlluminanceNormas.Add(illuminanceNorma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(illuminanceNorma);
        }     
        public IActionResult Delete(int? id)
        {
            SP52IndustrialLightRequirement ilns = db.SP52IndustrialLightRequirements.Find(id);
            db.SP52IndustrialLightRequirements.Remove(ilns);
            db.SaveChanges();
            return Redirect("~/SP52IndustNRequire/CreateEdit/#bottom");
        }
    }
}
