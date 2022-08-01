using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FlowerInventory.Models.Models
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ProductModel>();
        }

        public Task<List<ProductModel>> GetProductModelAsync()
        {
            return _database.Table<ProductModel>().ToListAsync();
        }

        public Task<int> SavePersonAsync(ProductModel productModel)
        {
            return _database.InsertAsync(productModel);
        }
    }
}
