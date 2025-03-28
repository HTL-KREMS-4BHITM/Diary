using Model;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ToDoListRepository:ARepositoryAsync<ToDoListItem>
{
    public ToDoListRepository(DiaryContext context) : base(context)
    {
    }
    
}