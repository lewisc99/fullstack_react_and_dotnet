using WebApi.Entities;

namespace WebApi.Database
{
    public interface IUserContext
    {
        IEnumerable<User> GetAll();

        void Add(User user);
    }
}
