using System.Collections.Generic;
using HomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HomeProject.Domain
{
    public class EFWorkHistoryItems : IWorkHistoryItems
    {
        private readonly TasksDBContext _context;

        public EFWorkHistoryItems(TasksDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WorkHistory>> GetWorkItems()
        {
            return await _context.WorkHistories.ToListAsync();
        }

        public async Task<WorkHistory> GetWorkItemById(int id)
        {
            return await _context.WorkHistories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveWorkItem(WorkHistory entity, int id)
        {
           
            if (entity.Id == default)
            {
                entity.EmployeeId = id;
               _context.Entry(entity).State = EntityState.Added;
                
            }
            else
            {
                entity.EmployeeId = id;
                _context.Entry(entity).State = EntityState.Modified;

            }

           await _context.SaveChangesAsync();

        }


        public async Task DeleteWorkItem(int id)
        {


            _context.WorkHistories.Remove(new WorkHistory() { Id = id });
           await _context.SaveChangesAsync();
        }
        public async Task DeleteWorkHistoryItem(int id)
        {

            var _work =  _context.WorkHistories.Where(a => a.EmployeeId == id);
            if (_work != null)
            {
               await _context.SaveChangesAsync();
            }
        }
    }
}
