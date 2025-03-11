using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("faculties")]
public class Faculty
{
    [Key]
    public int Id { get; set; }  // Birincil anahtar (Primary Key)

    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = string.Empty;  // Fakülte adı

    [ForeignKey("University")]
    public int UniversityId { get; set; }  // Üniversite ile ilişki

    public string? WhatsappLink { get; set; }  // WhatsApp linki opsiyonel (NULL olabilir)

    // Navigation Property
    public University? University { get; set; }  // Üniversite ile ilişki
}
