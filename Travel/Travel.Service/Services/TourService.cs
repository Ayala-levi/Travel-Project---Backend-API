using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Core.Repositories;
using Travel.Core.Services;
using Travel.Data.Entities;

namespace Travel.Service.Services
{
    public class TourService: ITourService
    {
        private readonly ITourRepository _tourRepository;

        public TourService(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public async Task<IEnumerable<Tour>> GetAllToursAsync()
        {
            return await _tourRepository.GetAllAsync();
        }

        public async Task<Tour> GetTourByIdAsync(int id)
        {
            return await _tourRepository.GetByIdAsync(id);
        }

        public async Task<Tour> AddTourAsync(Tour tour)
        {
            await _tourRepository.AddAsync(tour);
            return tour;
        }

        public async Task<Tour> UpdateTourAsync(Tour tour)
        {
            await _tourRepository.UpdateAsync(tour);
            return tour;
        }

        public async Task DeleteTourAsync(int id)
        {
            await _tourRepository.DeleteAsync(id);
        }
    }
}
