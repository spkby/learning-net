using BusStation.App_LocalResources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusStation.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int RoleId { get; set; }

        [Display(Name = nameof(Resource.rolename), ResourceType = typeof(Resource))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorlogin))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptyrole), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}