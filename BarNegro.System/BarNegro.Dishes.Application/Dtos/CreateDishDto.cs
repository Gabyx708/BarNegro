namespace BarNegro.Dishes.Application.Dtos
{
    public record CreateDishDto
    {
        public CreateDishDto(string description, decimal price, int categoryId)
        {
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
