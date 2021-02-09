using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uplift.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Service Name")]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Display(Name = "Description")]
        public string LongDesc { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name ="Image")]
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }
        //this shows that there is a foreign key relationship here and in the database it won't create these columns
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int FrequencyId { get; set; }

        [ForeignKey("FrequencyId")]
        public Frequency Frequency { get; set; }
    }
}
