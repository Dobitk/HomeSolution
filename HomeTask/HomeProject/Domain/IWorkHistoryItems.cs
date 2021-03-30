using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeProject.Models;

namespace HomeProject.Domain
{
    public interface IWorkHistoryItems
    {
        Task<IEnumerable<WorkHistory>> GetWorkItems();
        Task <WorkHistory> GetWorkItemById(int id);
        Task SaveWorkItem(WorkHistory entity, int id);
        Task DeleteWorkItem(int id);
        Task DeleteWorkHistoryItem(int id);
        
    }
}
