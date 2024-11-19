using System.ComponentModel.DataAnnotations;

namespace XceedTask.ViewModels
{
    public class RoleVM
    {
        [Display(Name ="Role Name") ,Required(ErrorMessage ="Enter Role Name")]
        public string RoleName { get; set; }
    }
}
