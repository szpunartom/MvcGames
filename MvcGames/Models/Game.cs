using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGames.Models
{
    public class Game
    {
        public int Id { get; set; }
        
        [StringLength(80)]
        [Required]
        public string Title { get; set; }
        
        [StringLength(80)]
        [Required]
        public string Platforms { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(30)]
        [Required]
        public string Genre { get; set; }

        [StringLength(50)]
        [Required]
        public string Developer { get; set; }

        [StringLength(50)]
        [Required]
        public string Publisher { get; set; }
    }
}
