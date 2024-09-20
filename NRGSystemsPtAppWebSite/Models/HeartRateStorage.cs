using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models;
public class HeartRateStorage
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("HrIndex")]
    public int HrIndex { get; set; }

    [Column("ClientdId")]
    public int ClientsId { get; set; }

    [Column("HeartRateTimeStamp")]
    [MaxLength(50)]
    public string HeartRateTimeStamp { get; set; }

    [Column("StorageData")]
    [MaxLength(50)]
    public string StorageData { get; set; }

    [Column("Times")]
    [MaxLength(20)]
    public string Times { get; set; } = null!;
}
