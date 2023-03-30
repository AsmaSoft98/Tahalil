using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Tahalil.API.Data;

namespace Tahalil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   
    //[Authorize]
    public class AnalController : ControllerBase
    {
        private readonly DataContext _context;

        public AnalController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Anal>>> GetAnals()

        {

            return await _context.Anal
                        .Include(u => u.User)
                        .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Anal>> GetAnal(int id)
        {
            return await _context.Anal.FindAsync(id);
        }

        [HttpGet("anals/{UserId}")]
        public async Task<ActionResult<List<Anal>>> GetUserAnal(int UserId)
        {

            User? user = await _context.User.FirstOrDefaultAsync(u => u.Id == UserId);

            if (user == null)
            {
                return NotFound();
            }
            IQueryable<Anal> anal = _context.Anal.Include(u => u.User);

            switch (user.Role)
            {
                case "Admin":
                    break;
                case "Prescript":
                    anal = anal.Where(m => m.PrescriptId == UserId);
                    break;
                case "Patient":
                    anal = anal.Where(m => m.UserId == UserId && m.User.Role == UserRole.Patient);
                    break;
                default:
                    throw new ArgumentException($"Invalid role: {user.Role}");
            }
            return await anal.ToListAsync();
        }


        [HttpGet( "GetStatus")]
        public async Task<string> GetLicenses()
        {
            try
            {
               
                return "licenses";
            }
            catch (Exception ex)
            {
                 throw;
            }
        }
    }
}