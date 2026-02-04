using WebApi.Entities;

namespace WebApi.Database;

public class UserContext : IUserContext
{
    private readonly List<User> _userContext = [ new ("Luiz", 20), new("Felipe", 25)];

    public IEnumerable<User> GetAll()
    {
        return _userContext.Select(u => new User(u.Name, u.Age));
    }

    public void Add(User user)
    {
        var userDb = _userContext.First(u => u.Name == user.Name);

        if (userDb == null)
            _userContext.Add(user);
    }
}