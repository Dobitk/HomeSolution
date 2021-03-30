using System.Threading.Tasks;
using HomeProject.Domain;
using HomeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeProject.Controllers
{


    public class EmployeeController : Controller
    {

        private readonly AllManager _manager;
        public EmployeeController(AllManager manager )
        {

            _manager = manager;
         }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _manager.employeeManager.GetEmployeeItems());
        }

        

        //Просмотр деталей сотрудников
        public async Task<IActionResult> DetalisEmployee(int id)
        {

            TempVariable.IdEmployee = id;
           return View(await _manager.employeeManager.GetEmployeeItemByIdAll(id));
        }

         [HttpGet] 

        public async Task<IActionResult> InsertEmployee(int id)
        {
           
            return View(await  _manager.employeeManager.GetEmployeeItemById(id));
        }

       


        [HttpPost]
        public async Task<IActionResult> InsertEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    var fdID = await _manager.employeeManager.SaveEmployeeItem(model);
                    
                    return RedirectToAction("DetalisEmployee", "Employee", new {id = fdID});
                }
            }
            return View();
        }

 
        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
  
          await _manager.employeeManager.DeleteEmployeeItem(id);

              return  RedirectToAction("Index", "Employee");

        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {


           
            return View(await _manager.employeeManager.GetEmployeeItemById(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                   await _manager.employeeManager.SaveEmployeeItem(model);

                return RedirectToAction("DetalisEmployee", "Employee",new { id = model.Id } );//

                }

            }
            return View(model);
        }

    }
}
