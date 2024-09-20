using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NRGSystemsPtAppWebSite.Models;
public class ClientsProgram
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("program_id")]
    public int ProgramId { get; set; }

    [Column("client_id")]
    public int ClientId { get; set; }

    [Column("clientsName")]
    [MaxLength(100)]
    public string? ClientName { get; set; }

    [Column("program_title")]
    [MaxLength(50)]
    public string? ProgramTitle { get; set; }

    [Column("date_issued")]
    [MaxLength(50)]
    public string? DateIssued { get; set; }

    [Column("number_of_visits")]
    public int NumberOfVisits { get; set; }

    [Column("program_used")]
    public int TimesProgramUsed { get; set; }

    [Column("exercise_name")]
    [MaxLength(50)]
    public string? NameOfExercise { get; set; }

    [Column("image_location")]
    [MaxLength(250)]
    public string? ImageGifLocation { get; set; }

    [Column("weights")]
    [MaxLength(50)]
    public string? Weights { get; set; }

    [Column("reps")]
    [MaxLength(50)]
    public string? Repetitions { get; set; }

    [Column("pt_comments")]
    [MaxLength(250)]
    public string? PtComments { get; set; }
}


