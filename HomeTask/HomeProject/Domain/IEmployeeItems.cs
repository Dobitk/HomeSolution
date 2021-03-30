using System.Collections.Generic;
using HomeProject.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomeProject.Domain
{
    public interface IEmployeeItems
    {
        Task<IEnumerable<Employee>> GetEmployeeItems();
        Task<Employee> GetEmployeeItemById(int id);
        Task<AllEmployeeWorkFamily> GetEmployeeItemByIdAll(int id);
        Task<int> SaveEmployeeItem(Employee entity);
        Task  DeleteEmployeeItem(int id);


    }
}
