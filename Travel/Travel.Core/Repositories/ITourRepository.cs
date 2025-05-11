using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data.Entities;

namespace Travel.Core.Repositories
{
    public interface ITourRepository
    {
        Task<IEnumerable<Tour>> GetAllAsync();
        Task<Tour> GetByIdAsync(int id);
        Task AddAsync(Tour entity);
        Task UpdateAsync(Tour entity);
        Task DeleteAsync(int id);
    }
}
