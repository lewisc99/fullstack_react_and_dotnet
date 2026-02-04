
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IUserService userService) : ControllerBase
{
    public IActionResult GetAll()
    {
        var users = userService.GetAll();
        return Ok(users);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateUserDto userDto)
    {
        var createdUser = userService.Create(userDto);

        return CreatedAtAction(nameof(GetAll), new { id = createdUser.Id }, createdUser);
    }
}