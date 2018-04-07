using BusStation.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusStation.Models
{
    public class Price
    {
        [Key]
        [Required]
        public int PriceId { get; set; }

        [RegularExpression(@"[\d| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorprice))]
        [Display(Name = nameof(Resource.seats), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptyprice))]
        public int PricePerKM { get; set; }

        [Display(Name = nameof(Resource.dateprice), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptydateprice))]
        public DateTime DatePrice { get; set; }

    }
}