using Market.DataAccess.Data;
using Market.DataAccess.Repository.IRepository;
using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Repository
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }
        public void Update(Product product)
        {
            _db.Update(product);
        }
    }
}
