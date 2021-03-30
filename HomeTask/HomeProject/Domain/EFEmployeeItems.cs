using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HomeProject.Domain
{
    public class EFEmployeeItems : IEmployeeItems
    {
        private readonly TasksDBContext _context;

        public EFEmployeeItems(TasksDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeItems()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeItemById(int id)
        {
            
            return await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<AllEmployeeWorkFamily> GetEmployeeItemByIdAll(int id)
        {

           var _empl = new AllEmployeeWorkFamily
            {
                Employees = await  _context.Employees.Where(x => x.Id == id).ToListAsync(),
                WorkHistories = await _context.WorkHistories.Where(y => y.EmployeeId == id).ToListAsync(),
                Families = await  _context.Families.Where(z => z.EmployeeId == id).ToListAsync()
            };
            return _empl;
        }

        public async Task<int> SaveEmployeeItem(Employee entity)
        {

            if (entity.Id == default)
            {


               _context.Entry(entity).State = EntityState.Added;

            }
            else
            {
 
                _context.Entry(entity).State = EntityState.Modified;
                
            }
            _context.SaveChanges();

            return _context.Employees.OrderByDescending(x => x.Id).FirstOrDefaultAsync().Result.Id;

        }

        public async Task  DeleteEmployeeItem(int id)
        {
            var  _empl = await _context.Employees.Include(a => a.WorkHistory)
                .Include(a => a.Family).FirstOrDefaultAsync(a => a.Id == id);
 
            _context.Employees.Remove(_empl);
            _context.SaveChanges();
        }


    }
}
