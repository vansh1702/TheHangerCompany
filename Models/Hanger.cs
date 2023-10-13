using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheHangerCompany
    .Models
{
    public class Hanger
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        
        public string Color { get; set; }
        public string Size { get; set; }
        public int MaxWeightCapacity { get; set; }
        public string Material { get; set; }


    }
}

