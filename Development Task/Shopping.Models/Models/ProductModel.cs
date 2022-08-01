using FlowerInventory.Models.Enums;

namespace FlowerInventory.Models.Models
{
    public class ProductModel: BaseModel
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public string Thumbnail { get; set; }

        public ProductsEnum Category { get; set; }
    }
}
