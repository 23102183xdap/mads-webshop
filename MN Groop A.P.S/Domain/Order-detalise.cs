using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Order_detalise : BaseStruktur
    {
        
        
        [Required]
        public int Antal { get; set; }

        public int Totalamount { get; set; }
        [Required]
        public int Totalamunt { get; set; }

        [Required]
        public int StkPris { get; set; }
       
        [ForeignKey("Produkt.Id")]
        public int ProduktId { get; set; }
        [ForeignKey("Order.Id")]
        public int Orderid { get; set; }
    }
}
