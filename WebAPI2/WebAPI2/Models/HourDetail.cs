using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class HourDetail
    {
        [Key]
        public int HourId { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Hour { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Day { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string TattooArtist { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Client { get; set; }

    }
}
