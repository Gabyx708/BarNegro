using BarNegro.Dishes.Application.Dtos;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Domain.Entities;
using BarNegro.Dishes.Domain.Interface;

namespace BarNegro.Dishes.Application.UseCase
{
    public class QueryDish : IQueryDish
    {
        private readonly IDishRepository _dishRepository;

        public QueryDish(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        public List<DishDto> GetAll()
        {
            var dishes = _dishRepository.GetAll();

            return dishes.Select(dish => MapToDish(dish)).ToList();
        }

        public List<DishDto> GetByCategory(int categoryId)
        {
            var categoryDishes = _dishRepository.GetAllByCategory(categoryId);

            return categoryDishes.Select(dish => MapToDish(dish)).ToList();
        }

        public DishDetailDto GetById(string id)
        {
            var foundDish = _dishRepository.GetById(id);

            return MapToDishWithDetails(foundDish);
        }

        private DishDto MapToDish(Dish dish)
        {
            return new DishDto(dish.Description,
                               dish.Price,
                               dish.CreationDate,
                               dish.Category.Description);
        }

        private DishDetailDto MapToDishWithDetails(Dish dish)
        {
            var priceHistoryComplete = dish.PriceHistory
                                            .Select(ph => MapHistoryItem(ph))
                                            .ToList();


            return new DishDetailDto(dish.Description,
                                     dish.Price,
                                     dish.CreationDate,
                                     dish.Category.Description,
                                     priceHistoryComplete);
        }

        private DishPriceHistoryDto MapHistoryItem(PriceHistory priceHistory)
        {
            return new DishPriceHistoryDto(priceHistory.Date,
                                           priceHistory.OriginalPrice,
                                           priceHistory.NewPrice,
                                           priceHistory.UserId,
                                           priceHistory.UserFullName);
        }
    }
}
