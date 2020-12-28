using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_7lab.Models
{
    public class Genres
    {
        [Key]
        public int genre_id { get; set; }
        [Required]

        public string genre { get; set; }
    }
}
