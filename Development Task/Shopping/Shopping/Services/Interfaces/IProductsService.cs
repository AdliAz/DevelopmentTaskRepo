using FlowerInventory.Models.Models;
using System.Collections.Generic;

namespace FlowerInventory.Services.Interfaces
{
    public interface IProductsService
    {
        /// <summary>
        /// Gets the available products list by category name.
        /// </summary>
        /// <param name="categoryName">The target category Name</param>
        /// <returns>The found prodycts.</returns>
        IEnumerable<ProductModel> GetProductsByGategoryName(string categoryName);
        IEnumerable<ProductModel> AddList(string name, int quantity, float price);

        /// <summary>
        /// Gets product images by the product ID.
        /// </summary>
        /// <param name="productId">The target product ID.</param>
        /// <returns>The method returns the found of product images list.</returns>
        //IEnumerable<string> GetProductsImages(long productId);
    }
}
