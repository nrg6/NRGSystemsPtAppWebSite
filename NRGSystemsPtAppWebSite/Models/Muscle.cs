using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models;
public class Muscle
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("muscle_id")]
    public int MuscleId { get; set; }

    [Column("muscle_name")]
    [MaxLength(50)]
    public string? Name { get; set; }

    [Column("muscle_image")]
    [MaxLength(250)]
    public string? Image { get; set; }

    [Column("muscle_string")]
    [MaxLength(50)]
    public string? StringName { get; set; }

    [Column("muscle_location")]
    [MaxLength(50)]
    public string? Location { get; set; }

    [Column("muscle_insertion")]
    [MaxLength(50)]
    public string? Insertion { get; set; }

    [Column("muscle_origin")]
    [MaxLength(50)]
    public string? Origin { get; set; }

    [Column("muscle_checked")]
    public bool IsChecked { get; set; }
}

