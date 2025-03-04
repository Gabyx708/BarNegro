using BarNegro.Dishes.Application.Dtos;

namespace BarNegro.Dishes.Application.Interfaces
{
    public interface IQueryDish
    {
        List<DishDto> GetAll();
        List<DishDto> GetByCategory(int categoryId);

        DishDetailDto GetById(string id);
    }
}
