using Microsoft.AspNetCore.Mvc;
using Travel.Core.Services;
using Travel.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Travel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly ITourService _tourService;

        public ToursController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTours()
        {
            var tours = await _tourService.GetAllToursAsync();
            return Ok(tours);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTourById(int id)
        {
            var tour = await _tourService.GetTourByIdAsync(id);
            if (tour == null)
            {
                return NotFound();
            }
            return Ok(tour);
        }

        [HttpPost]
        public async Task<IActionResult> AddTour(Tour tour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _tourService.AddTourAsync(tour);
            return CreatedAtAction(nameof(GetTourById), new { id = tour.TourId }, tour);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTour(int id, Tour tour)
        {
            if (id != tour.TourId)
            {
                return BadRequest("ID mismatch");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _tourService.UpdateTourAsync(tour);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTour(int id)
        {
            await _tourService.DeleteTourAsync(id);
            return NoContent();
        }
    }
}
