
using MVC.App_LocalResources;
using MVC.Localize;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVC.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [MyDisplayName(nameof(Resource1.loginname), NameResourceType = typeof(Resource1))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.errorlogin))]
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.emptylogin), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = nameof(Resource1.password), ResourceType = typeof(Resource1))]
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.emptypassword), AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string Password { get; set; }

        [Display(Name = nameof(Resource1.confpassword), ResourceType = typeof(Resource1))]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.passdontmatch))]
        [NotMapped]
        public string PasswordCnfm { get; set; }

        [Required]
        [DisplayName("roleId")]
        public int RoleId { get; set; }

        [Display(Name = nameof(Resource1.rolename), ResourceType = typeof(Resource1))]
        [NotMapped]
        public virtual Role role { get; set; }

        [Display(Name = nameof(Resource1.email), ResourceType = typeof(Resource1))]
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.emptyemail), AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = nameof(Resource1.erroremail))]
        [MaxLength(100)]
        public string Email { get; set; }


        public virtual ICollection<Message> messages { get; set; }

    }


}