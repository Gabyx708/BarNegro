using BarNegro.Dishes.Application.Dtos;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Domain.Entities;
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

        public DishDto ChangePrice(ChangeDishPriceDto change)
        {
            var found = _dishRepository.GetById(change.DishId);

            if (found == null)
            {
                throw new ArgumentException("invalid dish");
            }

            var historyRecord = CreatePriceHistoryRecord(found, change);

            found.Price = change.Price;
            found.PriceHistory.Add(historyRecord);

            _dishRepository.Update(found);

            return new DishDto(found.DishId,
                               found.Price,
                               found.CreationDate,
                               found.Category.Description);
        }

        private PriceHistory CreatePriceHistoryRecord(Dish dish,ChangeDishPriceDto change)
        {
            return new PriceHistory
            {
                Date = DateTime.Now,
                OriginalPrice = dish.Price,
                NewPrice = change.Price,
                DishId = dish.DishId,
                UserId = change.UserId,
                UserFullName = $"{change.UserName} {change.UserLastName}"
            };
        }
    }
}
