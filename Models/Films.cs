using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_7lab.Models
{
    public class Films
    {


        [Key]
        public int film_id { get; set; }

        [Required]
        [StringLength(50)]
        public string film { get; set; }

        [Required]
        public string main_director { get; set; }

        public decimal budget { get; set; }


    }
}
