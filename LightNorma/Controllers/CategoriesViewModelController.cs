using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using LightNorma.Models;
using LightNorma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LightNorma.Controllers
{
    public class CategoriesViewModelController : Controller
    {
        LightNormaDBContext db;
        
        public CategoriesViewModelController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<CategoriesViewModel> categoriesViewModels = new List<CategoriesViewModel>();
            CategoriesViewModel categoriesViewModel1=new();
            var bacs= db.BaseAppilcationCategories.ToList();
            var apc1s=db.AreaPlaceCategories1.ToList();
            for (int i = 0; i < bacs.Count(); i++)
            {
                var bac = bacs[i];
                for (int j = 0; j < apc1s.Count(); j++)
                {
                    var apc = apc1s[j];
                    var arps=db.AreaRoomPlaces.Where(a =>  a.BaseAppilcationCategoryId==bac.Id
                                                        && a.AreaPlaceCategory1Id==apc.Id
                                                     ).ToList();
                    CategoriesViewModel categoriesViewModel = new CategoriesViewModel
                    {
                        BaseAppilcationCategory = bac,
                        AreaPlaceCategory1 = apc,
                        AreaPlaceCategories0 = db.AreaPlaceCategories0.Where(apc0 => arps.Any(a => a.Id == apc0.Id)).ToList(),
                        AreaRoomPlaces = arps             
                    };
                    categoriesViewModels.Add(categoriesViewModel);
                }
            }

            /*ViewBag.BaseAppilcationCategories = db.BaseAppilcationCategories.ToList();
            ViewBag.AreaPlaceCategories1 = db.AreaPlaceCategories1.ToList();
            ViewBag.AreaPlaceCategories0 = db.AreaPlaceCategories0.ToList();
            ViewBag.AreaPlaceCategories0 = db.AreaPlaceCategories0.ToList();

            ViewBag.WorkRanks = db.SP52WorkRanks.ToList();
            ViewBag.WorkSubRanks = db.SP52WorkSubRanks.ToList();*/

            return View(categoriesViewModels);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            SelectList baseAppilcationCategories = new SelectList(db.BaseAppilcationCategories, "Id", "Name");
            ViewBag.bacList = baseAppilcationCategories;
            SelectList areaPlaceCategories1 = new SelectList(db.AreaPlaceCategories1, "Id", "Name");
            ViewBag.apc1List = areaPlaceCategories1;

            MultiSelectList areaPlaceCategories0 = new MultiSelectList(db.AreaPlaceCategories0, "Id", "Name");
            ViewBag.apcs = areaPlaceCategories0;
            MultiSelectList areaRoomPlaces = new MultiSelectList(db.AreaRoomPlaces, "Id", "Name");
            ViewBag.AreaRoomPlaces = areaRoomPlaces;
            
            

            /*
            ViewBag.SP52Illuminances = new SelectList(db.SP52Illuminances.ToList(),"Id","Value");
            List<string> typeNames=new List<string>{"Горизонтальная", "Вертикальная", 
                                                 "Цилиндрическая", "Полуцилиндрическая", "Произвольная"};//попробовать организовать в виде словаря, перечисления?
            ViewBag.TypeNames = new SelectList(typeNames);
            SelectList illuminances = new SelectList(db.SP52Illuminances, "Id", "Value");
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
        public IActionResult Create(IlluminanceNorma illuminanceNorma, List<string> illuminancePartial)
        {
            int s=illuminancePartial.Count;
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
