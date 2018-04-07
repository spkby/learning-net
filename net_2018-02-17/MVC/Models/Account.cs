using MVC.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Account
    {
        [Display(Name = nameof(Resource1.login), ResourceType = typeof(Resource1))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.errorlogin))]
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.emptylogin), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Login { get; set; }

        [Display(Name = nameof(Resource1.password), ResourceType = typeof(Resource1))]
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.emptypassword), AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string Password { get; set; }

        [Display(Name = nameof(Resource1.rememberMe), ResourceType = typeof(Resource1))]
        public bool RememberMe { get; set; }
    }
}