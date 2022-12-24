

using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
[Route("api/[controller]")]
    public class OrganisationController : ControllerBase
    {
        private readonly DataContext _context;
        public OrganisationController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task< ActionResult<IEnumerable<Organisations>>> GetOrganisations(){
            var organisations=await _context.Organisations.ToListAsync();
            return organisations;
        }
    }
}