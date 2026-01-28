using System.Diagnostics;
using WebApi.Database;
using WebApi.Dtos;

namespace WebApi.Services;

public class UserService(IUserContext userContext) : IUserService
{

    public IEnumerable<UserDto> GetAll()
    {
        return userContext.GetAll().Select(u => new UserDto(u.Id, u.Name, u.Age));
    }
}