using Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Interfaces
{
    public interface IItemCRUDService
    {
        bool CreateItem(Item item);
        List<Item> ReadItem();
        bool DeleteItem(int idItem);
        bool UpdateItem(Item item);
    }
}
