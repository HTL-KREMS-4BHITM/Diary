using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

[Table("USERS")]
public class Users
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ID", TypeName = "int")]
    public int UserId { get; set; }
    
    [Column("USER_NAME", TypeName = "varchar(45)")]
    public string Username { get; set; }
    
    [Column("PASSWORD_HASH", TypeName = "varchar(100)")]
    public string PasswordHash { get; set; }
    
}