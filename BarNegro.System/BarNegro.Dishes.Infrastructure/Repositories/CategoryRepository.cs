using BarNegro.Dishes.Domain.Entities;
using BarNegro.Dishes.Domain.Interface;
using BarNegro.Dishes.Infrastructure.Context;

namespace BarNegro.Dishes.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DishContext _context;

        public CategoryRepository(DishContext context)
        {
            _context = context;
        }

        public List<DishCategory> GetAll()
        {
            return _context.DishesCategory.ToList();
        }

        public DishCategory Inser(DishCategory category)
        {
            _context.DishesCategory.Add(category);
            _context.SaveChanges();
            return category;
        }
    }
}
