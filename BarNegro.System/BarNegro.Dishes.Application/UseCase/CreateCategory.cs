using BarNegro.Dishes.Application.Dtos;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Domain.Entities;
using BarNegro.Dishes.Domain.Interface;

namespace BarNegro.Dishes.Application.UseCase
{
    public class CreateCategory : ICreateCategory
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategory(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        CategoryDto ICreateCategory.CreateCategory(string description)
        {
            var category = new DishCategory { Description = description };

            var newCategory = _categoryRepository.Inser(category);

            return new CategoryDto(newCategory.CategoryId, newCategory.Description);
        }
    }
}
