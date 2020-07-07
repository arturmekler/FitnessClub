using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FitnessLessonsController : ControllerBase
    {
        private readonly FitnessClubContext _context;

        public FitnessLessonsController(FitnessClubContext context)
        {
            _context = context;
        }

        // GET: api/FitnessLessons
        [HttpGet]
        public IEnumerable<FitnessLesson> GetFitnessLesson()
        {
            return _context.FitnessLesson;
        }

        // GET: api/FitnessLessons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFitnessLesson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fitnessLesson = await _context.FitnessLesson.FindAsync(id);

            if (fitnessLesson == null)
            {
                return NotFound();
            }

            return Ok(fitnessLesson);
        }

        // PUT: api/FitnessLessons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFitnessLesson([FromRoute] int id, [FromBody] FitnessLesson fitnessLesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fitnessLesson.LessonId)
            {
                return BadRequest();
            }

            _context.Entry(fitnessLesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FitnessLessonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FitnessLessons
        [HttpPost]
        public async Task<IActionResult> PostFitnessLesson([FromBody] FitnessLesson fitnessLesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FitnessLesson.Add(fitnessLesson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFitnessLesson", new { id = fitnessLesson.LessonId }, fitnessLesson);
        }

        // DELETE: api/FitnessLessons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFitnessLesson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fitnessLesson = await _context.FitnessLesson.FindAsync(id);
            if (fitnessLesson == null)
            {
                return NotFound();
            }

            _context.FitnessLesson.Remove(fitnessLesson);
            await _context.SaveChangesAsync();

            return Ok(fitnessLesson);
        }

        private bool FitnessLessonExists(int id)
        {
            return _context.FitnessLesson.Any(e => e.LessonId == id);
        }
    }
}