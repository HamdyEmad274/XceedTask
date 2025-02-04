﻿using System.ComponentModel.DataAnnotations;

namespace XceedTask.ViewModels
{
    public class LoginUserVM
    {
        [Display(Name ="User Name"), Required(ErrorMessage ="Enter user name")]
        public string UserName { get; set; }
        [DataType(DataType.Password), Required(ErrorMessage = "Enter complex password")]
        public string Password { get; set; }

        public bool IsPersisite { get; set; }
    }
}
