using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("NORMAL_CONTENT")]
public class NormalContent:Entry
{
    [Column("CONTENT", TypeName = "TEXT")]
    public string Content { get; set; }
    
    
}