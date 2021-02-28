using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
