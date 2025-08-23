using Frigor.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frigor.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Get user with id
    /// </summary>
    /// <param name="id">Id of the user</param>
    /// <returns></returns>
    /// <response code="200">Successful</response>
    /// <response code="400">User with specified Id was not found</response>
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        var user = await _context.User.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        
        return Ok(user);
    }
}