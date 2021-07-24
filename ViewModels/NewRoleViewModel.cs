using System.ComponentModel.DataAnnotations;

namespace VideoRentalApps.ViewModels
{
    public class NewRoleViewModel
    {

        [Required]
        [Display(Name = "User Role Name")]
        public string RoleName { get; set; }


    }
}