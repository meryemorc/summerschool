using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("courses")]
public class Course
{
    [Key]
    public int Id { get; set; }  // Birincil anahtar (Primary Key)

    [Required]
    [MaxLength(50)]
    public string CourseCode { get; set; } = string.Empty;  // Ders kodu

    [Required]
    [MaxLength(255)]
    public string CourseName { get; set; } = string.Empty;  // Ders adı

    [Required]
    public int Kredi { get; set; }  // Kredi

    [Required]
    public int Akts { get; set; }  // AKTS

    [ForeignKey("Department")]
    public int DepartmentId { get; set; }  // Bölüm ile ilişki

    // Navigation Property
    public Department? Department { get; set; }  // Bölüm ile ilişki
}
