using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data.Entities;

namespace Travel.Core.Services
{
    public interface ITourService
    {
        Task<IEnumerable<Tour>> GetAllToursAsync();
        Task<Tour> GetTourByIdAsync(int id);
        Task<Tour> AddTourAsync(Tour tour);
        Task<Tour> UpdateTourAsync(Tour tour);
        Task DeleteTourAsync(int id);
    }
}
