using BarNegro.Dishes.Domain.Entities;

namespace BarNegro.Dishes.Domain.Interface
{
    public interface IDishRepository
    {
        Dish Insert(Dish dish);
        Dish GetById(string id);
        List<Dish> GetAll();
        List<Dish> GetAllByCategory(int categoryId);
        List<Dish> GetByDescription(string description);
    }
}
