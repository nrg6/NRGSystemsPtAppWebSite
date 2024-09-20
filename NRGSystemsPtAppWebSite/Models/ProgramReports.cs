using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NRGSystemsPtAppWebSite.Models
{
    [Table("reports")]
    public class ProgramReports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("report_id")]
        public int ReportId { get; set; }

        [Column("reported")]
        public int Reported { get; set; } = 0;

        [Column("time_of_session")]
        [MaxLength(100)]
        public string TimeOfSession { get; set; } = string.Empty;

        [Column("client_id")]
        public int ClientId { get; set; } = 0;

        [Column("clientsName")]
        [MaxLength(100)]
        public string ClientName { get; set; } = string.Empty;

        [Column("program_id")]
        public int ProgramId { get; set; } = 0;

        [Column("program_title")]
        [MaxLength(50)]
        public string? ProgramTitle { get; set; }

        [Column("date_issued")]
        [MaxLength(50)]
        public string DateIssued { get; set; } = string.Empty;

        [Column("exercise_name")]
        [MaxLength(50)]
        public string NameOfExercise { get; set; } = string.Empty;

        [Column("weights")]
        [MaxLength(50)]
        public string Weights { get; set; } = string.Empty;

        [Column("reps_completed")]
        [MaxLength(25)]
        public string RepsCompleted { get; set; } = string.Empty;

        [Column("training_time")]
        [MaxLength(50)]
        public string TrainingTime { get; set; } = string.Empty;

        [Column("resting_time")]
        [MaxLength(50)]
        public string RestingTime { get; set; } = string.Empty;

        [Column("clients_comments")]
        [MaxLength(250)]
        public string ClientsComments { get; set; } = string.Empty;
    }
}

