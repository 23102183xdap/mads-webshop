//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Domain
{
    public class BaseStruktur
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore] // jason gøre at de bliver inoreret med mindre de bliver kaldt og gør at klienten ikke kan se de data som jason har 
        public DateTime CreateAt { get; set; }

        [JsonIgnore]
        public DateTime? UpdatetAt { get; set; }

        [JsonIgnore]
        public DateTime? DelitedAt { get; set; }

    }
}
