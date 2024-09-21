using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models;
[Table("PT")]
public class PtModel
{
    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Column("image_gif")]
    [MaxLength(100)]
    public string ImageGif { get; set; } = string.Empty;

    [Column("qualifications")]
    [MaxLength(100)]
    public string Qualifications { get; set; } = string.Empty;


    [Column("specialities")]
    [MaxLength(150)]
    public string Specialities { get; set; } = string.Empty;

    [Column("phone")]
    [MaxLength(25)]
    public string Phone { get; set; } = string.Empty;

    [Column("email")]
    [MaxLength(75)]
    public string Email { get; set; } = string.Empty;

    [Column("enabled")]
    public int Enabled { get; set; }
}
