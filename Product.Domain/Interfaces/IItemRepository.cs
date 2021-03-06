using Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.Interfaces
{
    public interface IItemRepository
    {
        ICollection<Item> GetItems { get; }

        bool Save();
    }
}
