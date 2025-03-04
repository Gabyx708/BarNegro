namespace BarNegro.Dishes.Domain.Entities
{
    public class Dish
    {
        public string DishId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }
        public DishCategory Category { get; set; } = null!;

        public ICollection<PriceHistory> PriceHistory { get; set; } = null!;
    }
}
