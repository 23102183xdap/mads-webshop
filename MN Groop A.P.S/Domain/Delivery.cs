using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Delivery : BaseStruktur
    {
        //public int Id { get; set; }
        [Required]
        public int Antal { get; set; }

        public string name { get; set; }
        [Required]
        [StringLength(99, ErrorMessage = "name is to long")]
        public string address { get; set; }

        [Required]
        public int leveringspris { get; set; }

        [Required]
        [StringLength(9999, ErrorMessage = " to long deliverymethod")]
        public string leveringsmetode { get; set; }

        
    }
}
