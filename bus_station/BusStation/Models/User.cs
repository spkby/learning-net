
using BusStation.App_LocalResources;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BusStation.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Display(Name = nameof(Resource.loginname), ResourceType = typeof(Resource))]
        [RegularExpression(@"[\w| ]*", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.errorlogin))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptylogin), AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = nameof(Resource.password), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptypassword), AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string Password { get; set; }

        [Display(Name = nameof(Resource.confpassword), ResourceType = typeof(Resource))]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.passdontmatch))]
        [NotMapped]
        public string PasswordCnfm { get; set; }

        [Required]
        [DisplayName("RoleId")]
        public int RoleId { get; set; }

        [Display(Name = nameof(Resource.rolename), ResourceType = typeof(Resource))]
        [NotMapped]
        public virtual Role Role { get; set; }

        [Display(Name = nameof(Resource.email), ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.emptyemail), AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.erroremail))]
        [MaxLength(100)]
        public string Email { get; set; }


        public virtual ICollection<Ticket> Tickets { get; set; }

    }


}