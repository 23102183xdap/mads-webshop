using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class Kategori : BaseStruktur
    {
        public Kategori()
        {
            Produkts = new List<Produkt>();
        }

        [Required]
        [StringLength(32, ErrorMessage = "The Name is to long dum ass")]
        public string Title { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="The info is to long dum ass")]
        public string Beskrivelse { get; set; }

        public List<Produkt> Produkts { get; set; }


    }
}
