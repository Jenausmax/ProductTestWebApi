using Product.Domain.Interfaces;
using Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess
{
    public class DbRepositoryItem : IItemRepository
    {
        public ICollection<Item> GetItems => _db.Items.ToList();
        private ProductDBContext _db;
        public DbRepositoryItem(ProductDBContext dBContext)
        {
            _db = dBContext;
        }

        public bool Save(Item item)
        {
            if(item != null)
            {
                _db.Add(item);
                return true;
            }
            return false;
        }
    }
}
