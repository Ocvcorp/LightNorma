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
    public class IndustNormaController : Controller
    {
        LightNormaDBContext db;
        public IndustNormaController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult Create()
        {
            var setsILN = db.IndustrialLightNormaSets.Include(p => p.SP52IndustrialWorkRank)
                                                     .Include(p => p.SP52IndustrialWorkSubRank)
                                                     .Include(p => p.SP52BackgroundContrast)
                                                     .Include(p => p.SP52BackgroundCharacteristic)
                                                     .Include(p => p.CombinedCommonPartIlluminance)
                                                     .Include(p => p.CombinedTotalIlluminance)
                                                     .Include(p => p.CommonIlluminance);           
            ViewBag.DB =setsILN.ToList();

            SelectList sP52IndustrialWorkRanks = new SelectList(db.sp52industrialWorkRanks, "Id", "Value");
            ViewBag.SP52IndustrialWorkRanks = sP52IndustrialWorkRanks;

            SelectList sP52IndustrialWorkSubRanks = new SelectList(db.sp52industrialWorkSubRanks, "Id", "Value");
            ViewBag.SP52IndustrialSubWorkRanks = sP52IndustrialWorkSubRanks;

            SelectList BackgroundContrasts = new SelectList(db.sp52backgroundContrasts, "Id", "Value");
            ViewBag.BackgroundContrasts = BackgroundContrasts;

            SelectList SP52BackgroundCharacteristics = new SelectList(db.sp52BackgroundCharacteristics, "Id", "Value");
            ViewBag.SP52BackgroundCharacteristics = SP52BackgroundCharacteristics;

            SelectList CombinedTotalIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.CombinedTotalIlluminances = CombinedTotalIlluminances;

            SelectList CombinedCommonPartIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.CombinedCommonPartIlluminances = CombinedCommonPartIlluminances;

            SelectList CommonIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.CommonIlluminances = CommonIlluminances;

            return View();
        }
      
        [HttpPost]
        public IActionResult Create(IndustrialLightNormaSet industrialLightNormaSet)
        {
            if (ModelState.IsValid)
            {
                db.IndustrialLightNormaSets.Add(industrialLightNormaSet);
                db.SaveChanges();
                return RedirectToAction("Create", null, null, "bottom");
            }
            return View();
        }


        public IActionResult Edit(int id)
        {

            var setsILNup = from il in db.IndustrialLightNormaSets.Include(p => p.SP52IndustrialWorkRank)
                                                                  .Include(p => p.SP52IndustrialWorkSubRank)
                                                                  .Include(p => p.SP52BackgroundContrast)
                                                                  .Include(p => p.SP52BackgroundCharacteristic)
                                                                  .Include(p => p.CombinedCommonPartIlluminance)
                                                                  .Include(p => p.CombinedTotalIlluminance)
                                                                  .Include(p => p.CommonIlluminance)
                          where il.Id<id
                          select il;

            ViewBag.DBup = setsILNup.ToList();

            var setsILNdown = from il in db.IndustrialLightNormaSets.Include(p => p.SP52IndustrialWorkRank)
                                                     .Include(p => p.SP52IndustrialWorkSubRank)
                                                     .Include(p => p.SP52BackgroundContrast)
                                                     .Include(p => p.SP52BackgroundCharacteristic)
                                                     .Include(p => p.CombinedCommonPartIlluminance)
                                                     .Include(p => p.CombinedTotalIlluminance)
                                                     .Include(p => p.CommonIlluminance)
                            where il.Id > id
                            select il;

            ViewBag.DBdown = setsILNdown.ToList();

            IndustrialLightNormaSet ilns = db.IndustrialLightNormaSets.Find(id);

            
            int? workRankId = ilns.SP52IndustrialWorkRankId;
            int selectedValue =  (workRankId==null) ? 1 : db.sp52industrialWorkRanks.Find(workRankId).Id;
            SelectList sP52IndustrialWorkRanks = new SelectList(db.sp52industrialWorkRanks, "Id", "Value", selectedValue);          
            ViewBag.SP52IndustrialWorkRanks = sP52IndustrialWorkRanks;

            int? workSubRankId = ilns.SP52IndustrialWorkSubRankId;
            selectedValue = (workSubRankId == null) ? 1 : db.sp52industrialWorkSubRanks.Find(workSubRankId).Id;
            SelectList sP52IndustrialWorkSubRanks = new SelectList(db.sp52industrialWorkSubRanks, "Id", "Value", selectedValue);
            ViewBag.SP52IndustrialSubWorkRanks = sP52IndustrialWorkSubRanks;

            int? BackgroundContrastId = ilns.SP52BackgroundContrastId;
            selectedValue = (BackgroundContrastId == null) ? 1 : db.sp52backgroundContrasts.Find(BackgroundContrastId).Id;
            SelectList BackgroundContrasts = new SelectList(db.sp52backgroundContrasts, "Id", "Value", selectedValue);
            ViewBag.BackgroundContrasts = BackgroundContrasts;

            int? SP52BackgroundCharacteristicId = ilns.SP52BackgroundCharacteristicId;
            selectedValue = (SP52BackgroundCharacteristicId == null) ? 1 : db.sp52BackgroundCharacteristics.Find(SP52BackgroundCharacteristicId).Id;
            SelectList SP52BackgroundCharacteristics = new SelectList(db.sp52BackgroundCharacteristics, "Id", "Value", selectedValue);
            ViewBag.SP52BackgroundCharacteristics = SP52BackgroundCharacteristics;

            int? CombinedTotalIlluminanceId = ilns.CombinedTotalIlluminanceId;          
            SelectList CombinedTotalIlluminances = (CombinedTotalIlluminanceId == null) 
                                                ? new SelectList(db.sp52Illuminances, "Id", "Value")
                                                : new SelectList(db.sp52Illuminances, "Id", "Value", db.sp52Illuminances.Find(CombinedTotalIlluminanceId).Id); 
            ViewBag.CombinedTotalIlluminances = CombinedTotalIlluminances;
            
            int? CombinedCommonPartIlluminanceId = ilns.CombinedCommonPartIlluminanceId;
            SelectList CombinedCommonPartIlluminances = (CombinedCommonPartIlluminanceId == null)
                                                ? new SelectList(db.sp52Illuminances, "Id", "Value")
                                                : new SelectList(db.sp52Illuminances, "Id", "Value", db.sp52Illuminances.Find(CombinedCommonPartIlluminanceId).Id);
            ViewBag.CombinedCommonPartIlluminances = CombinedCommonPartIlluminances;

            int? CommonIlluminanceId = ilns.CommonIlluminanceId;
            SelectList CommonIlluminances = (CommonIlluminanceId == null)
                                                ? new SelectList(db.sp52Illuminances, "Id", "Value")
                                                : new SelectList(db.sp52Illuminances, "Id", "Value", db.sp52Illuminances.Find(CommonIlluminanceId).Id);
            ViewBag.CommonIlluminances = CommonIlluminances;
            return View(ilns);
        }
        
        [HttpPost]
        public IActionResult Edit(IndustrialLightNormaSet industrialLightNormaSet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(industrialLightNormaSet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Create", null,null,industrialLightNormaSet.Id.ToString());
            }
            return View();
        }


            

        public IActionResult Delete(int? id)
        {
            IndustrialLightNormaSet ilns = db.IndustrialLightNormaSets.Find(id);
            db.IndustrialLightNormaSets.Remove(ilns);
            db.SaveChanges();
            return RedirectToAction("Create");
        }
    }
}
