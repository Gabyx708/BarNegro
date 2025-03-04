namespace BarNegro.Dishes.Application.Dtos
{
    public record DishDetailDto
    {
        public DishDetailDto(string description, decimal price, DateTime creationDate, string category, List<DishPriceHistoryDto> history)
        {
            Description = description;
            Price = price;
            CreationDate = creationDate;
            Category = category;
            History = history;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public string Category { get; set; }

        public List<DishPriceHistoryDto> History { get; set; }
    }

    public record DishPriceHistoryDto
    {
        public DishPriceHistoryDto(DateTime date, decimal originalPrice, decimal newPrice, string userId, string userFullName)
        {
            Date = date;
            OriginalPrice = originalPrice;
            NewPrice = newPrice;
            UserId = userId;
            UserFullName = userFullName;
        }

        public DateTime Date { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
    }
}
