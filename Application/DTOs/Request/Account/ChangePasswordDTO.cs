using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request.Account
{
    public class ChangePasswordDTO
    {
        public string EmailAddress { get; set; } = string.Empty;
        public string CurrentPassword { get; set; } = string.Empty;
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$", ErrorMessage = "Your password must be a mix of Alphanumeric and special characters")]
        public string NewPassword { get; set; } = string.Empty;
    }
}
