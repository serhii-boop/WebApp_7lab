using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_7lab.Models
{
    public partial class Actors
    {


        [Key]
        public int actor_id { get; set; }

        [Required]
        public string name { get; set; }
        [Range(1, 150, ErrorMessage = "Введіть вік актора")]
        public int age { get; set; }

        [Required]
        public string nationality { get; set; }

        public string played_rolles { get; set; }

    }
}
