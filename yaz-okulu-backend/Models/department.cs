using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("deparments")]
public class Department
{
    [Key]
    public int Id { get; set; }  // Birincil anahtar (Primary Key)

    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = string.Empty;  // Bölüm adı

    [ForeignKey("Faculty")]
    public int FacultyId { get; set; }  // Fakülte ile ilişki

    // Navigation Property
    public Faculty? Faculty { get; set; }  // Fakülte ile ilişki
}
