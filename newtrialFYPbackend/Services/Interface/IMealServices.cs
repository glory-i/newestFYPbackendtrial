using newtrialFYPbackend.DTOs.MealDTOs;
using newtrialFYPbackend.Responses;
using System.Threading.Tasks;

namespace newtrialFYPbackend.Services.Interface
{
    public interface IMealServices
    {
        public Task<ApiResponse> createMeal(createMealDTO model);
    }
}
