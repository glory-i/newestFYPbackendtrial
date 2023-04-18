using newtrialFYPbackend.DTOs.MealDTOs;
using newtrialFYPbackend.Model;
using newtrialFYPbackend.Responses;
using System.Threading.Tasks;

namespace newtrialFYPbackend.Repository.Interface
{
    public interface IMealRepository
    {
        public Task<Meal> createMeal(Meal meal);
    }
}
