using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarNegro.Dishes.Application.Dtos
{
    public record  CreateDishDto
    {
        public CreateDishDto(string description, decimal price, string categoryId)
        {
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
    }
}
