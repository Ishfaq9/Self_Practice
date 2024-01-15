using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Self_Practice.Models.DBEntities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Price of the Product")]
        public double Price { get; set; }
        [DisplayName("Quantity of the Product")]
        public int Qty { get; set; }
    }
}
