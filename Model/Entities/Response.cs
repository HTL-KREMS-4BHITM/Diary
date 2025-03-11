using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

[Table("RESPONSES")]
public class Response
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("RESPONSE_ID", TypeName = "int")]
    public int ResponseId { get; set; }
    
    [Column("TEXT", TypeName = "varchar(45)")]
    public string Text { get; set; }
}