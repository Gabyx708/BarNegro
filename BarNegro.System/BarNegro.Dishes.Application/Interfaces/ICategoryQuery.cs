using BarNegro.Dishes.Application.Dtos;

namespace BarNegro.Dishes.Application.Interfaces
{
    public interface ICategoryQuery
    {
        List<CategoryDto> GetAll();
    }
}
