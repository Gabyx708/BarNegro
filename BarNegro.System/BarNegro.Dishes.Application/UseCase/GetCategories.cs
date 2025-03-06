using BarNegro.Dishes.Application.Dtos;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Domain.Interface;

namespace BarNegro.Dishes.Application.UseCase
{
    public class GetCategories : ICategoryQuery
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategories(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryDto> GetAll()
        {
            var categories = _categoryRepository.GetAll();

            return categories
                  .Select(cat => new CategoryDto(cat.CategoryId, cat.Description))
                  .ToList();
        }
    }
}
