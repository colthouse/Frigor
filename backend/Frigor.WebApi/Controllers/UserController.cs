using Frigor.Common.Dtos;
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
    [HttpGet("{uuid:guid}")]
    public async Task<IActionResult> GetUser(Guid uuid)
    {
        User? user = await context.User.FirstOrDefaultAsync(u => u.Uuid == uuid);

        if (user == null)
        {
            return NotFound();
        }
        
        return Ok(user.ToDto());
    }

    /// <summary>
    /// Create or get User with name
    /// </summary>
    /// <param name="name">Name of the User to create</param>
    /// <returns><see cref="UserDto"/></returns>
    /// <response code="200">User created</response>
    [HttpPost("{name}")]
    public async Task<IActionResult> CreateUser(string name)
    {
        var user = await context.User.FirstOrDefaultAsync(u => u.Name == name);
        if (user != null)
        {
            return Ok(user.ToDto());
        }

        var newUser = new User() {
            Name = name
        };
        
        context.User.Add(newUser);
        await context.SaveChangesAsync();
        
        return Ok(newUser.ToDto());
    }

    // <summary>
    // Get responsibilities from user
    // </summary>
    // <param name="uuid">UUID of user to get responsibilities from</param>
    // <returns>Responsibilities</returns>
    // <response code="200">Responsibilities from user</response>
    // <response code="400">Not found</response>
    // [HttpGet("responsibilities/{uuid:guid}")]
    // public async Task<IActionResult> GetResponsibilities(Guid uuid)
    // {
        // User? user = await context.User.FirstOrDefaultAsync(u => u.Uuid == uuid);

        // if (user == null)
        // {
        //     return NotFound();
        // }

        // var users = await context.User.Where(u => user.Responsibilities.Contains(u.Uuid)).ToListAsync();
        // return Ok(users);
    // }

    /// <summary>
    /// Gets all users expect oneself
    /// </summary>
    /// <param name="uuid"></param>
    /// <returns></returns>
    [HttpGet("all/{uuid:guid}")]
    public async Task<IActionResult> GetUsers(Guid uuid)
    {
        var users = await context.User.Where(u => u.Uuid != uuid).ToListAsync();

        return Ok(users);
    }
    
    [HttpGet("all/")]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await context.User.ToListAsync());
    }
}
