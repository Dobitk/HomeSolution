using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeProject.Models;

namespace HomeProject.Domain
{
    public interface IFamilyItems
    {
        Task<IEnumerable<Family>> GetFamilyItems();
        Task<Family> GetFamilyItemById(int id);
        Task SaveFamilyItem(Family entity, int id);
        Task DeleteFamilyItem(int id);
    }
}
