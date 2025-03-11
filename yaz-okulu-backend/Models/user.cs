using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
public class User
{
    [Key]
    public int Id { get; set; }  

    [Required]
    [MaxLength(255)]
    public string FullName { get; set; } = string.Empty;  

    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string Email { get; set; } = string.Empty;  

    [Required]
    public string PasswordHash { get; set; } = string.Empty;  

    [Required]
    [MaxLength(50)]
    [RegularExpression("^(student|assistant|admin)$", ErrorMessage = "Invalid role. Must be 'student', 'assistant' or 'admin'.")]
    public string Role { get; set; } = "student";  

    [ForeignKey("Faculty")]
    public int? FacultyId { get; set; }  

    public Faculty? Faculty { get; set; }  
}
