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
        
        public IlluminanceNormaController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var extractILN = db.IlluminanceNormas.Include(p => p.AreaRoomPlaces)
                                                 .Include(p => p.LightReglament)
                                                 .Include(p => p.illuminanceSets)
                                                 .ToList();
            ViewBag.WorkRanks = db.SP52WorkRanks.ToList();
            ViewBag.WorkSubRanks = db.SP52WorkSubRanks.ToList();


            return View(extractILN);
        }
        [HttpGet]
        public IActionResult Create()
        {
            MultiSelectList areaPlaceCategory0 = new MultiSelectList(db.AreaPlaceCategories0, "Id", "Name");
            ViewBag.AreaPlaceCategories0 = areaPlaceCategory0;
            MultiSelectList areaRoomPlaces = new MultiSelectList(db.AreaRoomPlaces, "Id", "Name");
            ViewBag.AreaRoomPlaces = areaRoomPlaces;
            
            SelectList sP52WorkRanks = new SelectList(db.SP52WorkRanks, "Id", "Value");
            ViewBag.SP52WorkRanks = sP52WorkRanks;
            SelectList sP52WorkSubRanks = new SelectList(db.SP52WorkSubRanks, "Id", "Value");
            ViewBag.SP52WorkSubRanks = sP52WorkSubRanks;


            ViewBag.SP52Illuminances = new SelectList(db.SP52Illuminances.ToList(),"Id","Value");
            List<string> typeNames=new List<string>{"Горизонтальная", "Вертикальная", 
                                                 "Цилиндрическая", "Полуцилиндрическая", "Произвольная"};//попробовать организовать в виде словаря, перечисления?
            ViewBag.TypeNames = new SelectList(typeNames);
            /*SelectList illuminances = new SelectList(db.SP52Illuminances, "Id", "Value");
            ViewBag.Illuminances = illuminances;
            SelectList combinedCommonIlluminances = new SelectList(db.SP52Illuminances, "Id", "Value");
            ViewBag.CombinedCommonIlluminances = illuminances;
            SelectList combinedLocalIlluminances = new SelectList(db.SP52Illuminances, "Id", "Value");
            ViewBag.CombinedLocalIlluminances = illuminances;*/         

            return View();
        }
        public IActionResult IlluminancePartial()
        {            
            
            return PartialView();
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
