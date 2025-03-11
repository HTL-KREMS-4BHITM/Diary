using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("NORMAL_CONTENTS")]
public class NormalContent:Entry
{
    [Column("CONTENT", TypeName = "TEXT")]
    public string Content { get; set; }
    
    
}