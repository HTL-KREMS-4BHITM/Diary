using Domain.Repositories.Interfaces;
using Model;
using Model.Configurations;

namespace Domain.Repositories.Implementations;

public class UserRepository:ARepositoryAsync<User>, IUserRepositoryAsync<User>
{
    public UserRepository(DiaryContext context) : base(context)
    {
    }

    public async Task<string> CheckUser(string username, string password, List<User> _users)
    {
        List<User> accountUsername = new();
        List<User> accountPassw = new();
        foreach (var user in _users)
        {
            if (user.Username == username) accountUsername.Add(user);
            if (user.Password == password) accountPassw.Add(user);
        }

        if (accountUsername.Count == 0 && accountPassw.Count == 0)
        {
            return "Username or Password is incorrect";

        }

        if (accountUsername.Count != 0)
        {
            if (accountPassw.Count == 0)
            {
                var passw = await ReadAsync(u => u.Username == username);
                accountUsername.Clear();
                return "Wrong Password... Your Password is " + passw[0].Password;
            }

            if (accountUsername[0].Password == password)
            {
                return null;
            }
        }

        if (accountPassw.Count != 0)
        {
            if (accountUsername.Count == 0)
            {
                var passw = await ReadAsync(u => u.Password == password);
                accountPassw.Clear();
                return $"Wrong Username... Your Username is {passw[0].Username}";
            }

            if (accountUsername[0].Username == username)
            {
                return null;
            }
        }

        return null;
    }
}  