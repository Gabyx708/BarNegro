using BarNegro.Dishes.Application.Dtos;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Domain.Interface;

namespace BarNegro.Dishes.Application.UseCase
{
    internal class ChangePriceDish : IChangeDishPrice
    {
        private readonly IDishRepository _dishRepository;

        public ChangePriceDish(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        public DishDto ChangePrice(string dishId, decimal price)
        {
            var found = _dishRepository.GetById(dishId);

            if (found == null)
            {
                throw new ArgumentException("invalid dish");
            }

            found.Price = price;
            _dishRepository.Update(found);

            return new DishDto(found.DishId,
                               found.Price,
                               found.CreationDate,
                               found.Category.Description);
        }
    }
}
