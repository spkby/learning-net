using BusStation.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusStation.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public int TicketId { get; set; }

        [Required]
        [DisplayName("TripId")]
        public int TripId { get; set; }

        [Display(Name = nameof(Resource.trip), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual Trip Trip { get; set; }

        [Display(Name = nameof(Resource.datepoll), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptydatepoll))]
        public DateTime DatePoll { get; set; }

        [Required]
        [DisplayName("UserId")]
        public int UserId { get; set; }

        [Display(Name = nameof(Resource.user), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual User User { get; set; }

        [RegularExpression(@"[\d| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorcounttickets))]
        [Display(Name = nameof(Resource.counttickets), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptycounttickets))]
        public int CountOfTickets { get; set; }
    }
}