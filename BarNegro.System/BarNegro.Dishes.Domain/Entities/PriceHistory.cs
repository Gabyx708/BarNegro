namespace BarNegro.Dishes.Domain.Entities
{
    public class PriceHistory
    {
        public DateTime Date { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;

        public string DishId { get; set; } = string.Empty;
        public Dish Dish { get; set; } = null!;
    }
}
