using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models;
public class Assessments
{
    //[PrimaryKey]
    //[AutoIncrement]
    [Column("assessments_id")]
    public int AssessmentsId { get; set; }

    [Column("clients_id")]
    public int ClientsId { get; set; } = 0;

    [Column("clients_bodyweight")]
    [MaxLength(10)]
    public string ClientsBodyWeight { get; set; } = string.Empty;

    [Column("exercise_name")]
    [MaxLength(100)]
    public string NameOfExercise { get; set; } = string.Empty;

    [Column("training_time")]
    [MaxLength(50)]
    public string TrainingTime { get; set; } = string.Empty;

    [Column("rest_time")]
    [MaxLength(50)]
    public string RestTime { get; set; } = string.Empty;

    [Column("weights_set")]
    [MaxLength(25)]
    public string WeightsSets { get; set; } = string.Empty;

    [Column("weights_achieved")]
    [MaxLength(25)]
    public string WeightsAchieved { get; set; } = string.Empty;

    [Column("reps_set")]
    [MaxLength(25)]
    public string RepsSet { get; set; } = string.Empty;

    [Column("reps_completed")]
    [MaxLength(25)]
    public string RepsCompleted { get; set; } = string.Empty;

    [Column("results_image")]
    [MaxLength(100)]
    public string ResultsImage { get; set; } = string.Empty;

    [Column("pt_comments")]
    [MaxLength(500)]
    public string PtComments { get; set; } = string.Empty;

    [Column("program_title")]
    [MaxLength(100)]
    public string ProgramTitle { get; set; } = string.Empty;
}



