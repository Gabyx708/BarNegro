using BarNegro.Dishes.Application.Dtos;

namespace BarNegro.Dishes.Application.Interfaces
{
    public interface ICreateCategory
    {
        CategoryDto CreateCategory(string description);
    }
}
