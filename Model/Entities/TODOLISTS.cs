using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("TODO_LISTS")]
public class TODOLISTS:Entry
{
    [Column("ITEMS")]
    public string Item{ get; set; }
}