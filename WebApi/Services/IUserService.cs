using WebApi.Dtos;

namespace WebApi.Services;

public interface IUserService
{
    IEnumerable<UserDto> GetAll();
}