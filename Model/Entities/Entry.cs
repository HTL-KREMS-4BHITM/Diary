using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("ENTRIES")]
public class Entry
{
    [Column("ENTRY_ID")]
    public int EntryId { get; set; }
    
    
    [Column("TITLE")]
    public string Title { get; set; }
    
    
    [Column("USER_ID")]
    public int UserId { get; set; }
    
    public User User { get; set; }
}