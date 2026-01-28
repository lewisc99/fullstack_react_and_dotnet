
using Microsoft.AspNetCore.Mvc;
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
}