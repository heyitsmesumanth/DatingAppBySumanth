using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers ;

[ApiController]
[Route("api/{controller}")]
public class UsersController : ControllerBase 
{

    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context; 
    }

    [HttpGet]
     public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
     {
        return await _context.Users.ToListAsync();
     }

   [HttpGet("{id}")] // /api/users/2
   public async Task<ActionResult<AppUser>> GetUser(int id)
   {
    return await _context.Users.FindAsync(id);
   }
   


}