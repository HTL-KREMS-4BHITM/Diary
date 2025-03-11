using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class DiaryContext:DbContext
{
    public DiaryContext(DbContextOptions<DiaryContext> options) : base(options)
    {
    }
    
    public DbSet<Entry> Entries { get; set; }
    public DbSet<NormalContent> NormalContents { get; set; }
    public DbSet<Response> Responses { get; set; }
    public DbSet<ToDoListItem> TodoListItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NormalContent>()
            .ToTable("NORMAL_CONTENTS");
        modelBuilder.Entity<ToDoListItem>()
            .ToTable("TODO_LIST_ITEMS");

        modelBuilder.Entity<Entry>()
            .HasOne<User>(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<ToDoListItem>()
            .HasOne<Entry>(t => t.Entry)
            .WithMany()
            .HasForeignKey(t => t.EntryId);
    }
}