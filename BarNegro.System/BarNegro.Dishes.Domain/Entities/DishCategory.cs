namespace BarNegro.Dishes.Domain.Entities
{
    public class DishCategory
    {
        public int CategoryId { get; set; }
        public string Description { get; set; } = string.Empty;

        public ICollection<Dish> Dishes { get; set; } = null!;
    }
}
