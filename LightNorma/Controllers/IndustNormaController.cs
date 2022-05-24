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
        static bool addUpdateSwitcher; //switching between Add/Update methods
        public IndustNormaController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult CreateEdit(int? id)
        {
            addUpdateSwitcher = (id == null); //true -add, false - update database
            id ??= db.IndustrialLightNormaSets.OrderBy(i => i.Id).LastOrDefault().Id;
            IndustrialLightNormaSet industrialLightNormaSet = db.IndustrialLightNormaSets.Find(id);

            //data for Create/Edit form
            SelectList sP52IndustrialWorkRanks = new SelectList(db.sp52industrialWorkRanks, "Id", "Value", industrialLightNormaSet.SP52IndustrialWorkRankId);
            ViewBag.SP52IndustrialWorkRanks = sP52IndustrialWorkRanks;

            SelectList sP52IndustrialWorkSubRanks = new SelectList(db.sp52industrialWorkSubRanks, "Id", "Value", industrialLightNormaSet.SP52IndustrialWorkSubRankId);
            ViewBag.SP52IndustrialWorkSubRanks = sP52IndustrialWorkSubRanks;

            SelectList BackgroundContrasts = new SelectList(db.sp52backgroundContrasts, "Id", "Value", industrialLightNormaSet.SP52BackgroundContrastId);
            ViewBag.SP52BackgroundContrasts = BackgroundContrasts;

            SelectList SP52BackgroundCharacteristics = new SelectList(db.sp52BackgroundCharacteristics, "Id", "Value", industrialLightNormaSet.SP52BackgroundCharacteristicId);
            ViewBag.SP52BackgroundCharacteristics = SP52BackgroundCharacteristics;

            SelectList CombinedTotalIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value", industrialLightNormaSet.CombinedTotalIlluminanceId);
            ViewBag.CombinedTotalIlluminances = CombinedTotalIlluminances;

            SelectList CombinedCommonPartIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value", industrialLightNormaSet.CombinedCommonPartIlluminanceId);
            ViewBag.CombinedCommonPartIlluminances = CombinedCommonPartIlluminances;

            SelectList CommonIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value", industrialLightNormaSet.CommonIlluminanceId);
            ViewBag.CommonIlluminances = CommonIlluminances;

            //data for _GetIndexPartial
            var extractILN = db.IndustrialLightNormaSets.Include(p => p.SP52IndustrialWorkRank)
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
        public IActionResult CreateEdit(IndustrialLightNormaSet industrialLightNormaSet)
        {
            if (ModelState.IsValid)
            {
                //Switch database actions
                if (addUpdateSwitcher)//Add case 
                {
                    db.IndustrialLightNormaSets.Add(industrialLightNormaSet);
                }
                else //Update case
                {
                    db.Entry(industrialLightNormaSet).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            return Redirect("~/IndustNorma/CreateEdit/#CreateEditForm");
        }     
        public IActionResult Delete(int? id)
        {
            IndustrialLightNormaSet ilns = db.IndustrialLightNormaSets.Find(id);
            db.IndustrialLightNormaSets.Remove(ilns);
            db.SaveChanges();
            return Redirect("~/IndustNorma/CreateEdit/#bottom");
        }
    }
}
