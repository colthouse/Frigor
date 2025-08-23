using Frigor.Common.Entities;
using Frigor.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frigor.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(AppDbContext context) : ControllerBase
{
    /// <summary>
    /// Get user with id
    /// </summary>
    /// <param name="uuid">Uuid of the user</param>
    /// <returns><see cref="IActionResult"/></returns>
    /// <response code="200">Successful</response>
    /// <response code="400">User with specified Id was not found</response>
    [HttpGet("{uuid}")]
    public async Task<IActionResult> GetUser(Guid uuid)
    {
        User? user = await context.User.FirstOrDefaultAsync(u => u.Uuid == uuid);

        if (user == null)
        {
            return NotFound();
        }
        
        return Ok(user.toDto());
    }

    /// <summary>
    /// Create User with name
    /// </summary>
    /// <param name="name">Name of the User to create</param>
    /// <returns><see cref="IActionResult"/></returns>
    /// <response code="200">User created</response>
    /// <response code="403">User with name already exists</response>
    [HttpPost("{name}")]
    public async Task<IActionResult> CreateUser(string name)
    {
        User? user = await context.User.FirstOrDefaultAsync(u => u.Name == name);
        if (user != null)
        {
            return StatusCode(403);
        }

        User newUser = new User(name);
        
        context.User.Add(newUser);
        await context.SaveChangesAsync();
        
        return Ok(newUser.Uuid);
    }
}
