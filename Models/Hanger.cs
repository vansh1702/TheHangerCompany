using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheHangerCompany.Models
{
    public class Hanger
    {
        public int Id { get; set; }



        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }



        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Type { get; set; }



        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        


        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Color { get; set; }

       

        [Required]
        [StringLength(10)]
        [RegularExpression(@"^[A-Z0-9]+[a-zA-Z0-9\s]*$")]
        public string Size { get; set; }

        

        [Required]
        [Range(1, 1000)]
        public int MaxWeightCapacity { get; set; }



        
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Material { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
