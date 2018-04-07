using BusStation.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusStation.Models
{
    public class Account
    {
        [Display(Name = nameof(Resource.login), ResourceType = typeof(Resource))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorlogin))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptylogin), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Login { get; set; }

        [Display(Name = nameof(Resource.password), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptypassword), AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string Password { get; set; }

        [Display(Name = nameof(Resource.rememberMe), ResourceType = typeof(Resource))]
        public bool RememberMe { get; set; }
    }
}