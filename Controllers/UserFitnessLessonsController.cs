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
    public class UserFitnessLessonsController : ControllerBase
    {
        private readonly FitnessClubContext _context;

        public UserFitnessLessonsController(FitnessClubContext context)
        {
            _context = context;
        }

        // GET: api/UserFitnessLessons
        [HttpGet]
        public IEnumerable<UserFitnessLesson> GetUserFitnessLesson()
        {
            return _context.UserFitnessLesson;
        }

        // GET: api/UserFitnessLessons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserFitnessLesson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userFitnessLesson = await _context.UserFitnessLesson.FindAsync(id);

            if (userFitnessLesson == null)
            {
                return NotFound();
            }

            return Ok(userFitnessLesson);
        }

        // PUT: api/UserFitnessLessons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserFitnessLesson([FromRoute] int id, [FromBody] UserFitnessLesson userFitnessLesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userFitnessLesson.UserFitnessLessonId)
            {
                return BadRequest();
            }

            _context.Entry(userFitnessLesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserFitnessLessonExists(id))
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

        // POST: api/UserFitnessLessons
        [HttpPost]
        public async Task<IActionResult> PostUserFitnessLesson([FromBody] UserFitnessLesson userFitnessLesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserFitnessLesson.Add(userFitnessLesson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserFitnessLesson", new { id = userFitnessLesson.UserFitnessLessonId }, userFitnessLesson);
        }

        // DELETE: api/UserFitnessLessons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserFitnessLesson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userFitnessLesson = await _context.UserFitnessLesson.FindAsync(id);
            if (userFitnessLesson == null)
            {
                return NotFound();
            }

            _context.UserFitnessLesson.Remove(userFitnessLesson);
            await _context.SaveChangesAsync();

            return Ok(userFitnessLesson);
        }

        private bool UserFitnessLessonExists(int id)
        {
            return _context.UserFitnessLesson.Any(e => e.UserFitnessLessonId == id);
        }
    }
}