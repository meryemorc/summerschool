using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("course_enrollments")]
public class CourseEnrollment
{
    [Key]
    public int Id { get; set; }  // Birincil anahtar (Primary Key)

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }  // Kullanıcı ile ilişki

    [Required]
    [ForeignKey("Course")]
    public int CourseId { get; set; }  // Ders ile ilişki

    [Required]
    public DateTime EnrollmentDate { get; set; }  // Kayıt tarihi

    // Navigation Properties
    public User? User { get; set; }  // Kullanıcı ilişkisi
    public Course? Course { get; set; }  // Ders ilişkisi
}
