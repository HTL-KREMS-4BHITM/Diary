using Model;
using Model.Configurations;

namespace Domain.Repositories.Implementations;

public class UserRepository:ARepositoryAsync<User>
{
    public UserRepository(DiaryContext context) : base(context)
    {
    }
    
}