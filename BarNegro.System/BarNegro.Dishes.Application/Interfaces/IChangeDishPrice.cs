using BarNegro.Dishes.Application.Dtos;

namespace BarNegro.Dishes.Application.Interfaces
{
    public interface IChangeDishPrice
    {
        DishDto ChangePrice(string dishId, decimal price);
    }
}
