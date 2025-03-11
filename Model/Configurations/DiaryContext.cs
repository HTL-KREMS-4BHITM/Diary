using Microsoft.EntityFrameworkCore;

namespace Model.Configurations;

public class DiaryContext:DbContext
{
    public DiaryContext(DbContextOptions<DiaryContext> options) : base(options)
    {
    }
    
    
}