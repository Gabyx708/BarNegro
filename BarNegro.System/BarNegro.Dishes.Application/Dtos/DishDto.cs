namespace BarNegro.Dishes.Application.Dtos
{
    public record DishDto
    {
        public DishDto(string description, decimal price, DateTime creationDate, string category)
        {
            Description = description;
            Price = price;
            CreationDate = creationDate;
            Category = category;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public string Category { get; set; }
    }
}
