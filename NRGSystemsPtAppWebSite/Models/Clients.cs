using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models;
public record Clients
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }

    [Column("first_name")]
    [MaxLength(100)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [MaxLength(100)]
    public string? LastName { get; set; }

    [Column("user_name")]
    [MaxLength(10)]
    public string? UserName { get; set; }

    [Column("password")]
    [MaxLength(25)]
    public string? Password { get; set; }

    [Column("email")]
    [MaxLength(100)]
    public string? Email { get; set; }

    [Column("phone")]
    [MaxLength(25)]
    public string? Phone { get; set; }

    [Column("dob")]
    public DateTime DoB { get; set; }

    [Column("sex")]
    [MaxLength(20)]
    public string? Sex { get; set; }

    [Column("height")]
    public float Height { get; set; }

    [Column("weight")]
    public float Weight { get; set; }

    [Column("enabled")]
    public int Enabled { get; set; }

    [Column("program_rev")]
    [MaxLength(500)]
    public string? ProgramRevisionNo { get; set; }

    [Column("report_rev")]
    [MaxLength(500)]
    public string? ReportRevisionNo { get; set; }

    [Column("message_rev")]
    [MaxLength(500)]
    public string? MessageRevisionNo { get; set; }

    public string FullName => $"{FirstName} {LastName}";

}

