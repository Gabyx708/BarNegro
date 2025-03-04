using BarNegro.Dishes.Application.Dtos;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Domain.Entities;
using BarNegro.Dishes.Domain.Interface;

namespace BarNegro.Dishes.Application.UseCase
{
    public class CreateDish : ICreateDish
    {
        private readonly IDishRepository _dishRepository;

        public CreateDish(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        bool ICreateDish.CreateDish(CreateDishDto dish)
        {
            if (dish.Description.Length > 5)
            {
                throw new ArgumentException("description is too short");
            }

            var newDish = Create(dish);

            try
            {
                _dishRepository.Insert(newDish);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private Dish Create(CreateDishDto dto)
        {
            return new Dish
            {
                DishId = CreateDishId(),
                IsDeleted = false,
                Description = dto.Description,
                CategoryId = dto.CategoryId,
                CreationDate = DateTime.Now,
                Price = dto.Price
            };
        }

        private string CreateDishId()
        {
            DateTime now = DateTime.Now;
            return $"DS-{now.ToString("yyyyMMddss")}";
        }


    }
}
