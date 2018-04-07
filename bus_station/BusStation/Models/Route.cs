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
    public class Route
    {
        [Key]
        [Required]
        public int RouteId { get; set; }
        
        [DisplayName("CityIdTo")]
        [Required]
        public int CityIdTo { get; set; }

        [Display(Name = nameof(Resource.cityto), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual City CityTo { get; set; }

        [Required]
        [DisplayName("CityIdFrom")]
        public int CityIdFrom { get; set; }

        [Display(Name = nameof(Resource.cityfrom), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual City CityFrom { get; set; }

        [Display(Name = nameof(Resource.distance), ResourceType = typeof(Resource))]
        [RegularExpression(@"[\d| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errordistance))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptydistance))]
        public int Distance { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }

    }
}