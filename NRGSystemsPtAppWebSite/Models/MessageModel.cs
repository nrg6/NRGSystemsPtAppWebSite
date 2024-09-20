using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.Models
{
    [Table("messages")]
    public class MessageModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("message_id")]
        public int MessageId { get; set; }

        [Column("time_of_message")]
        [MaxLength(100)]
        public string? TimeMessageSent { get; set; }

        [Column("text")]
        [MaxLength(500)]
        public string? Text { get; set; }

        [Column("message_read")]
        public int MessageRead { get; set; }

        [Column("client_id")]
        public int ClientsId { get; set; }

    }
}