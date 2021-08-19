using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Order : BaseStruktur
    {
        
        [Required]
        public DateTime OrderDate { get; set; }

        [ForeignKey("Login.Id")]
        public int LoginId { get; set; }
    }
}
