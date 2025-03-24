using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class EntryRepository : ARepositoryAsync<Entry>, IRepositoryAsync<Entry>
{
    public EntryRepository(DiaryContext context) : base(context)
    {
    }
    
    public async Task<List<Entry>> GetEntriesForUser(int userid)
    {
        return await Table.Where(e => e.UserId == userid).ToListAsync();
    }
}