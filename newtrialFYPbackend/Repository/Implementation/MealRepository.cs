using newtrialFYPbackend.Authentication;
using newtrialFYPbackend.Model;
using newtrialFYPbackend.Repository.Interface;
using System;
using System.Threading.Tasks;

namespace newtrialFYPbackend.Repository.Implementation
{
    public class MealRepository : IMealRepository
    {
        private readonly ApplicationDbContext _context;
        public MealRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Meal> createMeal(Meal meal)
        {
            try
            {
                var newMeal = await _context.Meals.AddAsync(meal);
                await _context.SaveChangesAsync();
                return meal;
            }

            catch(Exception e)
            {
                return null;
            }
            

        }
    }
}
