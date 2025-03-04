using BarNegro.Dishes.Domain.Entities;
using BarNegro.Dishes.Domain.Interface;
using BarNegro.Dishes.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BarNegro.Dishes.Infrastructure.Repositories
{
    public class DishRepository : IDishRepository
    {
        private readonly DishContext _context;

        public DishRepository(DishContext context)
        {
            _context = context;
        }

        public Dish Insert(Dish dish)
        {
            _context.Dishes.Add(dish);
            _context.SaveChanges();
            return dish;
        }

        public List<Dish> GetAll()
        {
            return _context.Dishes.ToList();
        }

        public List<Dish> GetAllByCategory(int categoryId)
        {
            return _context.Dishes.Where(d => d.CategoryId == categoryId).ToList();
        }

        public List<Dish> GetByDescription(string description)
        {
            return _context.Dishes.Where(d => d.Description.Contains(description)).ToList();
        }

        public Dish GetById(string id)
        {
            return _context.Dishes.
                            Include(dish => dish.PriceHistory)
                            .FirstOrDefault(dish => dish.DishId == id) ??
                            throw new NullReferenceException();
        }

        public Dish Update(Dish dish)
        {

            var existingDish = GetById(dish.DishId);

            if (existingDish == null)
            {
                throw new NullReferenceException();
            }

            existingDish.Description = dish.Description;
            existingDish.Price = dish.Price;

            _context.Dishes.Update(existingDish);
            _context.SaveChanges();
            return existingDish;
        }
    }
}
