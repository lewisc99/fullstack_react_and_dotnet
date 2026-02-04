using System.Diagnostics;
using WebApi.Database;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Services;

public class UserService(IUserContext userContext) : IUserService
{

    public IEnumerable<UserDto> GetAll()
    {
        return userContext.GetAll().Select(u => new UserDto(u.Id, u.Name, u.Age));
    }

    public UserDto Create(CreateUserDto input)
    {
        var newUser = new User()
        {
            Name = input.Name,
            Age = input.Age
        };

        userContext.Add(newUser);

        return new UserDto(newUser.Id, newUser.Name, newUser.Age);
    }
}