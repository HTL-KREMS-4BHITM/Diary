using Model;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class NormalContentRepository:ARepositoryAsync<NormalContent>
{
    public NormalContentRepository(DiaryContext context) : base(context)
    {
    }
    
}