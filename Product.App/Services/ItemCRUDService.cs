using Product.Domain.Interfaces;
using Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.App.Services
{
    public class ItemCRUDService : IItemCRUDService
    {
        private readonly IItemRepository _repository;
        public ItemCRUDService(IItemRepository repository)
        {
            _repository = repository;
        }
        public bool CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public List<Item> ReadItem()
        {
            return _repository.GetItems.ToList();
        }

        public bool UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
