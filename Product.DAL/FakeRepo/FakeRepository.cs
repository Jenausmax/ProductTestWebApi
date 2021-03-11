using Product.Domain.Interfaces;
using Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.FakeRepo
{
    public class FakeRepository : IItemRepository
    {

        public ICollection<Item> GetItems => Repo.Items;

        public bool Save(Item item)
        {
            if(item != null)
            {
                Repo.Items.Add(item);
                return true;
            }
            return false;
        }
    }

    public static class Repo
    {
        public static List<Item> Items = new List<Item> 
        {
            new Item { Id = 1, ProductName = "Bal1", Description = "Bal One", Price = 23 },
            new Item { Id = 2, ProductName = "Bal2", Description = "Bal Two", Price = 25 },
            new Item{ Id = 3, ProductName = "Bal3", Description = "Bal Tr", Price = 26 } 
        };

    }
}
