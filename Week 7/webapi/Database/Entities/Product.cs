using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("product")]
public class Student
{
    [Column("student_id")]
    [Key]
    public long studentId {get; set;}

    [Column("email_address")]
    public string emailAddress {get; set;}
}