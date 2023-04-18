using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newtrialFYPbackend.Model.NutritionModels;
using newtrialFYPbackend.Responses.Enums;
using newtrialFYPbackend.Responses;
using newtrialFYPbackend.Services.Interface;
using System.Threading.Tasks;
using newtrialFYPbackend.DTOs.MealDTOs;

namespace newtrialFYPbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMealServices _mealServices;
        public MealController(IMealServices mealServices)
        {
            _mealServices = mealServices;
        }

        [HttpPost("CreateMeal")]
        public async Task<ActionResult<ApiResponse>> CreateMeal([FromForm] createMealDTO model)
        {

            var response = await _mealServices.createMeal(model);
            if (response.Message == ApiResponseEnum.success.ToString())
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }

        }

    }
}
