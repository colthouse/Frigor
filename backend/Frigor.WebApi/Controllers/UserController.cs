using Frigor.Common.Entities;
using Frigor.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frigor.WebApi.Controllers;

[ApiController]
[Route("/user")]
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
    /// <returns><see cref="IActionResult"/></returns>
    /// <response code="200">Successful</response>
    /// <response code="400">User with specified Id was not found</response>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var user = await _context.User.FirstOrDefaultAsync(u => u.Id == id);
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
        var user = await _context.User.FirstOrDefaultAsync(u => u.Name == name);
        if (user != null)
        {
            return Forbid();
        }
        
        var createdUser = _context.User.Add(new User(name));
        await _context.SaveChangesAsync();
        
        return Ok(createdUser.Entity.Id);
    }
}