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

    internal static class Repo
    {
        public static List<Item> Items = new List<Item>();

    }
}
