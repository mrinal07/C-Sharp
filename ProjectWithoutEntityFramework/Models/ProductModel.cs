using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWithoutEntityFramework.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
