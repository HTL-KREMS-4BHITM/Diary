using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Model.Entities;
[Table("ENTRIES")]
public class Entry
{
    [Column("ENTRY_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public int EntryId { get; set; }
    
    
    [Column("TITLE")]
    public string Title { get; set; }
    
    [Column("DATE")]
    public DateTime Date { get; set; }
    
    
    [Column("USER_ID")]
    public int UserId { get; set; }
    
    public User User { get; set; }
}