using FlowerInventory.Models.Enums;
using FlowerInventory.Models.Models;
using FlowerInventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerInventory.Services
{
    public class ProductsService : IProductsService
    {
        /// <summary>
        /// Gets the available products list by category name.
        /// </summary>
        /// <param name="categoryName">The target category Name</param>
        /// <returns>The found prodycts.</returns>
        public IEnumerable<ProductModel> GetProductsByGategoryName(string categoryName)
        {
            List<ProductModel> mockList = new List<ProductModel>
            {
                new ProductModel{ID = 1, Category = ProductsEnum.Flowers, Quantity = 10, Name = "Mums", Price = 15, Thumbnail = "https://media.istockphoto.com/photos/turquoise-flower-chrysanthemum-garden-flower-white-isolated-with-picture-id670309760?s=612x612" },
                new ProductModel{ID = 2, Category = ProductsEnum.Flowers, Quantity = 12,Name = "Chrysanthemum", Price = 14, Thumbnail = "https://media.istockphoto.com/photos/chrysanthemum-picture-id186867963?s=612x612" },
                new ProductModel{ID = 3, Category = ProductsEnum.Flowers, Quantity = 13,Name = "Gerbera", Price = 16, Thumbnail = "https://media.istockphoto.com/photos/gerbera-picture-id171312337?s=612x612" },
                new ProductModel{ID = 4, Category = ProductsEnum.Flowers, Quantity = 14,Name = "Sunflower", Price = 13, Thumbnail = "https://media.istockphoto.com/photos/sunflower-isolated-picture-id174648035?s=612x612" },
                new ProductModel{ID = 5, Category = ProductsEnum.Flowers, Quantity = 15,Name = "Orchid", Price = 15, Thumbnail = "https://media.istockphoto.com/photos/orchid-picture-id502037779?s=612x612"},
                new ProductModel{ID = 6, Category = ProductsEnum.Flowers, Quantity = 13,Name = "lily", Price = 20, Thumbnail = "https://media.istockphoto.com/photos/white-flower-lilium-candidum-isolated-picture-id524859923?s=612x612"},
                new ProductModel{ID = 7, Category = ProductsEnum.Flowers, Quantity = 14,Name = "Rose", Price = 34, Thumbnail = "https://media.istockphoto.com/photos/rose-blossom-picture-id531535155"},
                new ProductModel{ID = 8, Category = ProductsEnum.Flowers, Quantity = 17,Name = "Carnation", Price = 23, Thumbnail = "https://media.istockphoto.com/photos/carnation-picture-id185275691"},
                new ProductModel{ID = 9, Category = ProductsEnum.Flowers, Quantity = 13,Name = "Peony", Price = 22, Thumbnail = "https://media.istockphoto.com/photos/close-up-of-pink-peony-picture-id103332955"},
                new ProductModel{ID = 10, Category = ProductsEnum.Flowers, Quantity = 12,Name = "Hibiscus", Price = 9, Thumbnail = "https://media.istockphoto.com/photos/red-hibiscus-flower-isolated-on-white-background-picture-id979217998?s=612x612"},
                new ProductModel{ID = 11, Category = ProductsEnum.Flowers, Quantity = 15,Name = "Daisy", Price = 32, Thumbnail = "https://media.istockphoto.com/photos/daisy-on-white-with-clipping-path-picture-id182838201?s=612x612"},
                new ProductModel{ID = 12, Category = ProductsEnum.Flowers, Quantity = 16,Name = "Iris", Price = 29, Thumbnail = "https://media.istockphoto.com/photos/iris-picture-id514310332?s=612x612"}
            };
;
            return mockList;
        }

        /// <summary>
        /// Gets product images by the product ID.
        /// </summary>
        /// <param name="productId">The target product ID.</param>
        /// <returns>The method returns thhe found list of products.</returns>
        public IEnumerable<string> GetProductsImages(long productId)
        {
            return null;
        }
    }
}
