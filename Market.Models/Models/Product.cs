using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Market.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Product Name")]
        public string Tittle { get; set; }

        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }

        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        [Display( Name = "List Price 1-50")]
        [Range(1,1000)]
        public double Price { get; set; }
        
        [Display(Name = "List Price 50+")]
        [Range(1, 1000)]
        public double Price50 { get; set; }

        [Display(Name = "List Price 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }
    }
}
