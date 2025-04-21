using Model;

namespace Domain.Repositories.Interfaces;

public interface IUserRepositoryAsync<TEntity>:IRepositoryAsync<TEntity> where TEntity : class
{
    Task<string> CheckUser(string username, string password, List<User> _users);
}