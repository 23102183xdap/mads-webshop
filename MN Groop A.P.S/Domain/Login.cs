using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Login : BaseStruktur
    {
        
        [Required]
        [StringLength(40, ErrorMessage = " mail to long fiks it !! or your fired ")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Password does not match to long or rong password")]
        public string Password { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}
