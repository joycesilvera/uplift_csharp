using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Uplift.Models
{
    public class Category
    {
        [Key] //makes primary key which is auto-required
        public int Id { get; set; }

        [Required]
        [Display(Name="Category Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
    }
}
