using System.Collections.ObjectModel;

namespace ApiCatalogo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Product>? Products { get; set; }

        public Category()
        {
            Products = new Collection<Product>();
        }
    }
}
