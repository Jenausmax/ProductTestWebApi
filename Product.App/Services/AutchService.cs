using Product.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace App.Tests
{
    public class AutchService : IAutchService
    {
        public AutchService()
        {
            Base = new List<string>()
            {
                "Сидоров",
                "Петров",
                "Иванов"

            };
        }

        private List<string> Base { get; set; }

        public bool Login(string lastName)
        {
            return Base.Contains(lastName);
        }
    }
}