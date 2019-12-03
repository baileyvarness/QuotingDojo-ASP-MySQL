using System;
using System.ComponentModel.DataAnnotations;
 
namespace QuotingDojo.Models

{
    public class Quote
    {
        [Required]
        [MinLength(2)]
        [Display(Name="Your Name: ")]
        public string YourName { get; set; }
        [Required]
        [Display(Name="Your Quote: ")]
        public string YourQuote { get; set; }
        public string created_at { get; set; }
    }
}