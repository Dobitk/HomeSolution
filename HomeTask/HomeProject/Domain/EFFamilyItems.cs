using System.Collections.Generic;
using HomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HomeProject.Domain
{
    public class EFFamilyItems : IFamilyItems
    {
        private readonly TasksDBContext _context;

        public EFFamilyItems(TasksDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Family>> GetFamilyItems()
        {
            return await _context.Families.ToListAsync();
        }

        public async Task<Family> GetFamilyItemById(int id)
        {
            return await _context.Families.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveFamilyItem(Family entity, int id)
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

        public async Task DeleteFamilyItem(int id)
        {


            _context.Families.Remove(new Family() { Id = id });
            await _context.SaveChangesAsync();
        }

    }
}
