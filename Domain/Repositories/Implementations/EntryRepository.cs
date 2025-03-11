using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class EntryRepository : ARepositoryAsync<Entry>
{
    public EntryRepository(DiaryContext context) : base(context)
    {
    }
}