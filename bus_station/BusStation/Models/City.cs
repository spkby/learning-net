using BusStation.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusStation.Models
{
    public class City
    {
        [Key]
        [Required]
        public int CityId { get; set; }

        [Display(Name = nameof(Resource.cityname), ResourceType = typeof(Resource))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorlogin))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptylogin), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string CityName { get; set; }

        public virtual ICollection<Route> RoutesTo { get; set; }
        public virtual ICollection<Route> RoutesFrom { get; set; }

    }
}