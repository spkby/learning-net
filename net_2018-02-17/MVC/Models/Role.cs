using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int RoleId { get; set; }
        
        [DisplayName("role")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "error role")]
        [Required(ErrorMessage = "enter role", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string roleName { get; set; }

        public virtual ICollection<User> users { get; set; }

    }
}