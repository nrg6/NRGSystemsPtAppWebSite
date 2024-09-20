using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NRGSystemsPtAppWebSite.Models;
[Table("heart_rate")]
public class HeartRate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("index")]
    public int index { get; set; }
    [Column("bpm")]
    public int HeartRate_bpm { get; set; }
    [Column("hrv")]
    public int HeartRateVariability { get; set; }
    [Column("contact")]
    [MaxLength(25)]
    public string HeartRateContactPoint { get; set; } = string.Empty;
    [Column("bat")]
    public int HeartRateBatteryPercent { get; set; }
    [Column("ee")]
    public int EnergyExpenditure { get; set; }
    [Column("time")]
    [MaxLength(50)]
    public string Timestamp { get; set; } = string.Empty;
}


