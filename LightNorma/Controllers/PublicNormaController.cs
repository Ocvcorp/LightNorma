using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using LightNorma.Models;
using LightNorma.Models.SP52Constants;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LightNorma.Controllers
{
    
    public class PublicNormaController : Controller
    {
        LightNormaDBContext db;         
        static bool addUpdateSwitcher; //switching between Add/Update methods
               
        public PublicNormaController(LightNormaDBContext context)
        {
            db = context;
        }
        public IActionResult CreateEdit(int? id)
        {
            
            addUpdateSwitcher = (id == null); //true -add, false - update database
                
            id ??= db.PublicLightNormaSets.OrderBy(p => p.Id).LastOrDefault().Id;
            PublicLightNormaSet publicLightNormaSet = db.PublicLightNormaSets.Find(id);
            
            //data for Create/Edit form
            SelectList sP52PublicWorkRanks = new SelectList(db.sp52publicWorkRanks, "Id", "Value");
            ViewBag.SP52publicWorkRanks = sP52PublicWorkRanks;

            SelectList sP52publicWorkSubRanks = new SelectList(db.sp52publicWorkSubRanks, "Id", "Value");
            ViewBag.SP52publicSubWorkRanks = sP52publicWorkSubRanks;

            SelectList horizontalIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.HorizontalIlluminances = horizontalIlluminances;

            SelectList cylindricalIlluminances = new SelectList(db.sp52Illuminances, "Id", "Value");
            ViewBag.CylindricalIlluminances = cylindricalIlluminances;

            var pLNNotes = db.sP52PublicLightNormaNotes.Include(n => n.publicLightNormaSets)
                                                    .Where(n => n.publicLightNormaSets.Any(p => p.Id == publicLightNormaSet.Id))
                                                    .ToList();
            var selectedPLNNotes = pLNNotes.Select(n => n.Id).ToList();
            MultiSelectList sp52PublicLightNormaNotes = new MultiSelectList(db.sP52PublicLightNormaNotes, "Id", "Designation", selectedPLNNotes);
            ViewBag.SP52PublicLightNormaNotes = sp52PublicLightNormaNotes;           
                        
            SelectList lightReglaments = new SelectList(db.LightReglaments, "Id", "Name", publicLightNormaSet.LightReglamentId);
            ViewBag.LightReglaments = lightReglaments;

            SelectList users = new SelectList(db.Users, "Id", "Name", publicLightNormaSet.UserId);
            ViewBag.Users = users;

            //data for _GetIndexPartial
            var extractPLN = db.PublicLightNormaSets.Include(p => p.SP52PublicWorkRank)
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

            //_GetIndexPartial: Lists for adding Note-marker (** or ***) to some data
            List<bool> isTwoStarNote = new List<bool>();            
            List<bool> isThreeStarNote = new List<bool>();
            foreach (var item in db.PublicLightNormaSets)
            {
                pLNNotes = db.sP52PublicLightNormaNotes.Include(n => n.publicLightNormaSets)
                                                    .Where(n => n.publicLightNormaSets.Any(p => p.Id == item.Id))
                                                    .ToList();
                selectedPLNNotes = pLNNotes.Select(n => n.Id).ToList();
                if (selectedPLNNotes.IndexOf(2) != -1)
                {
                    isTwoStarNote.Add(true);                   
                }
                else
                {
                    isTwoStarNote.Add(false);
                }

                if (selectedPLNNotes.IndexOf(3) != -1)
                {
                    isThreeStarNote.Add(true);
                }
                else
                {
                    isThreeStarNote.Add(false);
                }
            }
            ViewBag.isTwoStarNote = isTwoStarNote;
            ViewBag.isThreeStarNote = isThreeStarNote;


            return View(publicLightNormaSet);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEdit(PublicLightNormaSet publicLightNormaSet)
        {            
           if (ModelState.IsValid)
           {
                    //table Notes
                    if (!addUpdateSwitcher)//may be there are old nodes 
                    {
                        //Removing old notes from linking table
                        var notes2Remove = db.publicLightNormaSetSP52PublicLightNormaNotes
                                        .Where(x => x.publicLightNormaSetsId == publicLightNormaSet.Id)
                                        .ToList();
                        if (notes2Remove != null)
                        {
                            db.RemoveRange(notes2Remove);
                        }
                    }
                    //Adding new notes
                    if (publicLightNormaSet.SP52PNSelectedNotes != null)
                    {
                        var notes = db.sP52PublicLightNormaNotes
                                    .Where(n => publicLightNormaSet.SP52PNSelectedNotes.Contains(n.Id))
                                    .ToList();
                        publicLightNormaSet.SP52PublicLightNormaNotes.AddRange(notes);
                        db.SaveChanges();                    
                    }
                //Switch database actions
                if (addUpdateSwitcher)//Add case 
                {                    
                    db.PublicLightNormaSets.Add(publicLightNormaSet);                   
                }
                else //Update case
                {                    
                    db.Entry(publicLightNormaSet).State = EntityState.Modified;    
                }
                db.SaveChanges();                   
           }           
           return Redirect("~/PublicNorma/CreateEdit/#CreateEditForm"); 
            
        }
        
        public IActionResult Delete(int? id)
        {
            PublicLightNormaSet plns = db.PublicLightNormaSets.Find(id);
            db.PublicLightNormaSets.Remove(plns);
            db.SaveChanges();
            return Redirect("~/PublicNorma/CreateEdit/#CreateEditForm");
        }
    }
}
