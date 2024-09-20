using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models;
[Table("Exercises")]
public class Exercise
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("exercise_id")]
    public int ExerciseId { get; set; }

    [Column("exercise_name")]
    [MaxLength(50)]
    public string? ExerciseName { get; set; }

    [Column("image_gif")]
    [MaxLength(100)]
    public string? ImageGif { get; set; }

    [Column("preperation")]
    [MaxLength(500)]
    public string? InstructionPreperation { get; set; }

    [Column("execution")]
    [MaxLength(500)]
    public string? InstructionExecution { get; set; }

    [Column("comments")]
    [MaxLength(500)]
    public string? Comments { get; set; }

    [Column("mechanics")]
    [MaxLength(50)]
    public string? ClassificationMechanics { get; set; }

    [Column("rom")]
    [MaxLength(50)]
    public string? ClassificationROM { get; set; }

    [Column("force")]
    [MaxLength(50)]
    public string? ClassificationForce { get; set; }

    [Column("target")]
    [MaxLength(100)]
    public string? MuscleTarget { get; set; }

    [Column("group")]
    [MaxLength(100)]
    public string? MuscleGroup { get; set; }

    [Column("synergist")]
    [MaxLength(500)]
    public string? MuscleSynergists { get; set; }

    [Column("stabilizer")]
    [MaxLength(500)]
    public string? MuscleStabilizers { get; set; }

    [Column("enabled")]
    public int? Enabled { get; set; }

}


