using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Core;
using Travel.Core.Repositories;
using Travel.Data.Entities;

namespace Travel.Data.Repositories
{
    public class TourRepository : ITourRepository
    {
        private readonly DataContext _context;

        public TourRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tour>> GetAllAsync()
        {
            return await _context.Tours.ToListAsync();
        }

        public async Task<Tour> GetByIdAsync(int id)
        {
            return await _context.Tours.FindAsync(id);
        }

        public async Task AddAsync(Tour entity)
        {
            await _context.Tours.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tour entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var tourToDelete = await _context.Tours.FindAsync(id);
            if (tourToDelete != null)
            {
                _context.Tours.Remove(tourToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}

