using WebApi.Entities;

namespace WebApi.Database;

public class UserContext : IUserContext
{
    private readonly List<User> _userContext = new();

    public IEnumerable<User> GetAll()
    {
        return _userContext.Select(u => new User(u.Name, u.Age));
    }
}