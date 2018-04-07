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
    public class Trip
    {

        [Key]
        [Required]
        public int TripId { get; set; }

        [Display(Name = nameof(Resource.date), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptydate))]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("BusId")]
        public int BusId { get; set; }

        [Display(Name = nameof(Resource.number), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual Bus Bus { get; set; }

        [Required]
        [DisplayName("RouteId")]
        public int RouteId { get; set; }

        [Display(Name = nameof(Resource.route), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual Route Route { get; set; }


        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}