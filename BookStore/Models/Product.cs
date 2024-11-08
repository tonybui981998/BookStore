﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
      
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public String ISBN { get; set; }
        [Required]
        public String Author { get; set; }

        [Required]
        [Display(Name = "List-price")]
        //[Range(1,1000)] 
        public Double ListPrice { get; set; }

        [Required]
        [Display(Name = "price for 1-50")]
        //[Range(1, 1000)]

        public Double Price { get; set; }
        [Required]
        [Display(Name = "price for 50+")]
        //[Range(1, 1000)]
        public Double Price50 { get; set; }

       
        [Required]
        [Display(Name = "price for 100+")]
        //[Range(1, 1000)]
        public Double Price100 { get; set; }
    }
}
