using BarNegro.Dishes.Domain.Entities;

namespace BarNegro.Dishes.Domain.Interface
{
    public interface ICategoryRepository
    {
        DishCategory Inser(DishCategory category);
        List<DishCategory> GetAll();
    }
}
