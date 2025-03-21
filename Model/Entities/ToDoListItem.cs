using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("TODO_LIST_ITEMS")]
public class ToDoListItem
{
    [Column("ITEM_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public int ItemId { get; set; }
    
    [Column("ENTRY_ID")]
    public int EntryId { get; set; }
    
    public Entry Entry { get; set; }   
    
    [Column("CONTENT")]
    public string Content { get; set; }
    
}