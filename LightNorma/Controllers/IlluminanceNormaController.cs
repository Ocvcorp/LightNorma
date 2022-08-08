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
                                                .Include(p => p.CombinedCommonIlluminance)
                                                .Include(p => p.CombinedLocalIlluminance)
                                                .Include(p => p.CylindricalIlluminance)
                                                .Include(p => p.Illuminance)
                                                .Include(p => p.LightReglament)
                                                .Include(p => p.SSphIlluminancePlane)                                   
                                                .ToList();
            ViewBag.PublicWorkRanks = db.sp52publicWorkRanks.ToList();
            ViewBag.IndustrialWorkRanks = db.sp52industrialWorkRanks.ToList();
            ViewBag.PublicWorkSubRanks = db.sp52publicWorkSubRanks.ToList();
            ViewBag.IndustrialWorkSubRanks = db.sp52industrialWorkSubRanks.ToList();

            return View(extractILN);
        }
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

            SelectList CombinedTotalIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value", industrialLightNormaSet.CombinedTotalIlluminanceId);
            ViewBag.CombinedTotalIlluminances = CombinedTotalIlluminances;

            SelectList CombinedCommonPartIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value", industrialLightNormaSet.CombinedCommonPartIlluminanceId);
            ViewBag.CombinedCommonPartIlluminances = CombinedCommonPartIlluminances;

            SelectList CommonIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value", industrialLightNormaSet.CommonIlluminanceId);
            ViewBag.CommonIlluminances = CommonIlluminances;

            //data for _GetIndexPartial
            var extractILN = db.SP52IndustrialLightRequirements.Include(p => p.SP52IndustrialWorkRank)
                                                     .Include(p => p.SP52IndustrialWorkSubRank)
                                                     .Include(p => p.SP52BackgroundContrast)
                                                     .Include(p => p.SP52BackgroundCharacteristic)
                                                     .Include(p => p.CombinedCommonPartIlluminance)
                                                     .Include(p => p.CombinedTotalIlluminance)
                                                     .Include(p => p.CommonIlluminance);
            if (addUpdateSwitcher)
            {
                ViewBag.DbAboveId = extractILN.ToList();
            }
            else
            {
                ViewBag.DbAboveId = extractILN.Where(r => r.Id < id).ToList();
            }
            ViewBag.DbBelowId = extractILN.Where(r => r.Id > id).ToList();

            return View(industrialLightNormaSet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEdit(SP52IndustrialLightRequirement industrialLightNormaSet)
        {
            if (ModelState.IsValid)
            {
                //Switch database actions
                if (addUpdateSwitcher)//Add case 
                {
                    db.SP52IndustrialLightRequirements.Add(industrialLightNormaSet);
                }
                else //Update case
                {
                    db.Entry(industrialLightNormaSet).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            return Redirect("~/SP52IndustNRequire/CreateEdit/#CreateEditForm");
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
