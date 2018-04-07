using BusStation.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusStation.Models
{
    public class Bus
    {
        [Key]
        [Required]
        public int BusId { get; set; }

        [Display(Name = nameof(Resource.number), ResourceType = typeof(Resource))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errornumber))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptynumber), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Number { get; set; }

        [RegularExpression(@"[\d| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorseats))]
        [Display(Name = nameof(Resource.seats), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptyseats))]
        public int Seats { get; set; }


        [RegularExpression(@"[\d| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorcoefficient))]
        [Display(Name = nameof(Resource.coefficient), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptycoefficient))]
        public int Coefficient { get; set; }
        

        public virtual ICollection<Trip> Trips { get; set; }


    }
}