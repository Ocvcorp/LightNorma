using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using LightNorma.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LightNorma.Controllers
{
    
    public class SP52PublicNRequireController : Controller
    {
        LightNormaDBContext db;         
        static bool addUpdateSwitcher; //switching between Add/Update methods
               
        public SP52PublicNRequireController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult CreateEdit(int? id)
        {
            
            addUpdateSwitcher = (id == null); //true -add, false - update database
                
            id ??= db.SP52PublicLightRequirements.OrderBy(p => p.Id).LastOrDefault().Id;
            SP52PublicLightRequirement publicLightNormaSet = db.SP52PublicLightRequirements.Find(id);
            
            //data for Create/Edit form
            SelectList sP52PublicWorkRanks = new SelectList(db.SP52WorkRanks, "Id", "Value");
            ViewBag.SP52publicWorkRanks = sP52PublicWorkRanks;

            SelectList sP52publicWorkSubRanks = new SelectList(db.SP52WorkSubRanks, "Id", "Value");
            ViewBag.SP52publicSubWorkRanks = sP52publicWorkSubRanks;

            SelectList horizontalIlluminances = new SelectList(db.SP52Illuminances, "Id", "Value");
            ViewBag.HorizontalIlluminances = horizontalIlluminances;

            SelectList cylindricalIlluminances = new SelectList(db.SP52Illuminances, "Id", "Value");
            ViewBag.CylindricalIlluminances = cylindricalIlluminances;

            var pLNNotes = db.SP52PublicLightNormaNotes.Include(n => n.sp52PublicLightRequirements)
                                                    .Where(n => n.sp52PublicLightRequirements.Any(p => p.Id == publicLightNormaSet.Id))                                                    
                                                    .ToList();
            var selectedPLNNotes = pLNNotes.Select(n => n.Id).ToList();
            MultiSelectList sp52PublicLightNormaNotes = new MultiSelectList(db.SP52PublicLightNormaNotes.OrderBy(n=>n.Designation), "Id", "Designation", selectedPLNNotes);
            ViewBag.SP52PublicLightNormaNotes = sp52PublicLightNormaNotes;           
                        
            SelectList lightReglaments = new SelectList(db.LightReglaments, "Id", "Name", publicLightNormaSet.LightReglamentId);
            ViewBag.LightReglaments = lightReglaments;

            SelectList users = new SelectList(db.Users, "Id", "Name", publicLightNormaSet.UserId);
            ViewBag.Users = users;

            //data for _GetIndexPartial
            var extractPLN = db.SP52PublicLightRequirements.Include(p => p.SP52PublicWorkRank)
                                                    .Include(p => p.SP52PublicWorkSubRank)
                                                    .Include(p => p.HorizontalIlluminance)
                                                    .Include(p => p.CylindricalIlluminance)
                                                    .Include(p => p.SP52PublicLightNormaNotes)
                                                    .Include(p => p.LightReglament)
                                                    .Include(p => p.User);
            
            if (addUpdateSwitcher)
            {
                ViewBag.DbAboveId = extractPLN.ToList();
            }
            else
            {
                ViewBag.DbAboveId = extractPLN.Where(r => r.Id < id).ToList();
            }
            ViewBag.DbBelowId = extractPLN.Where(r => r.Id > id).ToList();

            return View(publicLightNormaSet);
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEdit(int?  id, SP52PublicLightRequirement publicLightNormaSet, int[] selectedNotes)
        {
            if (ModelState.IsValid)
            {               
                //Switch database actions
                if (addUpdateSwitcher)//Add case 
                {
                    //Adding new notes
                    if (selectedNotes.Any())
                    {
                        var notes = db.SP52PublicLightNormaNotes
                                    .Where(n => selectedNotes.Contains(n.Id))
                                    .ToList();
                        publicLightNormaSet.SP52PublicLightNormaNotes.AddRange(notes);
                    }
                    db.SP52PublicLightRequirements.Add(publicLightNormaSet);                   
                }
                else //Update case
                {                   
                    db.Entry(publicLightNormaSet).State = EntityState.Modified;
                    UpdateMany2Many(id, selectedNotes);
                }
                db.SaveChanges();                   
            }           
            return Redirect("~/SP52PublicNRequire/CreateEdit/#CreateEditForm");             
        }
        
        private void UpdateMany2Many(int? id, int[] selectedNotes)
        {
            var publicLightNormaSet = db.SP52PublicLightRequirements.FirstOrDefault(pl => pl.Id == id);
            //adding/changing notes
            var notesList = db.SP52PublicLightNormaNotes.Include(n => n.sp52PublicLightRequirements).ToList();
            var oldNotes = notesList.Where(n => n.sp52PublicLightRequirements.Any(p => p.Id == id)).ToList();
            //Removing old notes
            if (oldNotes.Any())
            {
                foreach (var note in oldNotes)
                {
                    publicLightNormaSet.SP52PublicLightNormaNotes.Remove(note);
                }
            }
            //Adding new notes
            if (selectedNotes.Any())
            {
                var notes = db.SP52PublicLightNormaNotes
                            .Where(n => selectedNotes.Contains(n.Id))
                            .ToList();
                publicLightNormaSet.SP52PublicLightNormaNotes.AddRange(notes);
            }
            db.Entry(publicLightNormaSet).State = EntityState.Modified;
            db.SaveChanges();
        }
        public IActionResult Delete(int? id)
        {
            SP52PublicLightRequirement plns = db.SP52PublicLightRequirements.FirstOrDefault(plr=>plr.Id==id);
            db.SP52PublicLightRequirements.Remove(plns);
            db.SaveChanges();
            return Redirect("~/SP52PublicNRequire/CreateEdit/#CreateEditForm");
        }
    }
}
