using System;
using System.ComponentModel.DataAnnotations;

namespace Uplift.Models
{
    public class Frequency
    {
        [Key] //makes primary key which is auto-required
        public int Id { get; set; }

        [Required]
        [Display(Name = "Frequency Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Frequency Count")]
        public int FrequencyCount { get; set; }
    }
}
