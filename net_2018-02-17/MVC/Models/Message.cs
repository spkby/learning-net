using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class Message
    {
        [Key]
        [Required]
        public int MessageID { get; set; }

        [Required]
        [DisplayName("MessageDatetime")]
        [DefaultValue("getDate()")]
        [DataType(DataType.DateTime)]
        public DateTime Datetime { get; set; }

        [Required]
        [DisplayName("MessageText")]
        public string MessageText { get; set; }

        [Required]
        [DisplayName("UserId")]
        public int UserId { get; set; }

        [DisplayName("Username")]
        [NotMapped]
        public virtual User user { get; set; }
    }
}