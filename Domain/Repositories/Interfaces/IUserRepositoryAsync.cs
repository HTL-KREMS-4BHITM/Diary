using Model;

namespace Domain.Repositories.Interfaces;

public interface IUserRepositoryAsync:IRepositoryAsync<User>
{
    Task<string> CheckUser(string username, string password, List<User> _users);
}