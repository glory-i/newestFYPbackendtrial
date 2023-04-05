using newtrialFYPbackend.Authentication;
using newtrialFYPbackend.Model.NutritionModels;
using newtrialFYPbackend.Responses;
using System.Threading.Tasks;


namespace newtrialFYPbackend.Services.Interface
{
    public interface INutritionServices
    {
        public Task<ApiResponse> NutritionCalculator(NutritionCalculatorRequestModel model);
    }
}
