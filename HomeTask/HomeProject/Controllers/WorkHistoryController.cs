using System;
using System.Threading.Tasks;
using HomeProject.Domain;
using HomeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeProject.Controllers
{
    public class WorkHistoryController : Controller
    {
        private readonly AllManager _manager;
        

        public WorkHistoryController(AllManager manager)
        {
            _manager = manager;
            
        }



        [HttpGet]
        public IActionResult InsertWorkHistory()
        {
           ViewBag.EmployeeID = TempVariable.IdEmployee;
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> InsertWorkHistory(WorkHistory model)
        {
            if (ModelState.IsValid)
            {

                if (model != null)
                {
                    var ggg = TempVariable.IdEmployee;
                  await _manager.workManager.SaveWorkItem(model, ggg );


                    return RedirectToAction("DetalisEmployee", "Employee", new { Id = ggg});
                }

            }
            return View();
        
        }


        [HttpGet]
        public async Task<IActionResult> EditWorkHistory(int id)
        {
           
            ViewBag.EmployeeID = TempVariable.IdEmployee;

            return View(await _manager.workManager.GetWorkItemById(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditWorkHistory(WorkHistory model)
        {
            if (ModelState.IsValid)
            {

                if (model != null)  
                {
                   if  (DateTime.Compare(model.StartDate, model.EndDate) <= 0)
                   {
                       await _manager.workManager.SaveWorkItem(model, TempVariable.IdEmployee);
 

                        return RedirectToAction("DetalisEmployee", "Employee", new {Id = TempVariable.IdEmployee});
                   }

                }

            }
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> DeleteWorkHistory(int id)
        {
            await _manager.workManager.DeleteWorkItem(id);

            return RedirectToAction("DetalisEmployee", "Employee", new { Id = TempVariable.IdEmployee });
        }
    }
}
