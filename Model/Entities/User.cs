using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public enum EModus
{
    IsMagic, 
    IsNormal
}

[Table("USERS")]
public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ID", TypeName = "int")]
    public int UserId { get; set; }
    
    [Column("USER_NAME", TypeName = "varchar(45)")]
    public string Username { get; set; }
    
    [Column("PASSWORD", TypeName = "varchar(100)")]
    public string Password { get; set; }
    
    [Column("MODUS")]
    public EModus Modus { get; set; }
    
}