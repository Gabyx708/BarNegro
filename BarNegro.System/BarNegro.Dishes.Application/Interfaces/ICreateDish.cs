using BarNegro.Dishes.Application.Dtos;

namespace BarNegro.Dishes.Application.Interfaces
{
    public interface ICreateDish
    {
        bool CreateDish(CreateDishDto dish);
    }
}
