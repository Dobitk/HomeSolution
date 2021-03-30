using HomeProject.Domain;
using HomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HomeProject.Controllers
{
    public class FamelyController : Controller
    {

        private readonly AllManager _manager;


        public FamelyController(AllManager manager)
        {
            _manager = manager;

        }

        [HttpGet]
        public IActionResult InsertFamily()
        {
            ViewBag.EmployeeID = TempVariable.IdEmployee;
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> InsertFamily(Family model)
        {
            if (ModelState.IsValid)
            {

                if (model != null)
                {
                    var ggg = TempVariable.IdEmployee;
                    await _manager.familyManager.SaveFamilyItem(model, ggg);

                    return RedirectToAction("DetalisEmployee", "Employee", new { Id = ggg });
                }

            }
            return View();

        }


        [HttpGet]
        public async Task<IActionResult> EditFamily(int id)
        {
            
            ViewBag.EmployeeID = TempVariable.IdEmployee;

            return View(await _manager.familyManager.GetFamilyItemById(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditFamily(Family model)
        {
            if (ModelState.IsValid)
            {

                if (model != null)
                {
                         await _manager.familyManager.SaveFamilyItem(model, TempVariable.IdEmployee);

                        return RedirectToAction("DetalisEmployee", "Employee", new { Id = TempVariable.IdEmployee });
 
                }

            }
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> DeleteFamily(int id)
        {
            await _manager.familyManager.DeleteFamilyItem(id);

            return RedirectToAction("DetalisEmployee", "Employee", new { Id = TempVariable.IdEmployee });
        }
    }
}
