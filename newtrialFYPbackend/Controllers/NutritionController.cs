﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newtrialFYPbackend.Authentication;
using newtrialFYPbackend.Responses.Enums;
using newtrialFYPbackend.Responses;
using newtrialFYPbackend.Services.Interface;
using System.Threading.Tasks;
using newtrialFYPbackend.Model.NutritionModels;

namespace newtrialFYPbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionController : ControllerBase
    {
        private readonly INutritionServices _nutritionService;
        public NutritionController(INutritionServices nutritionService)
        {
            _nutritionService = nutritionService;
        }

        [HttpPost("CalculateNutritionRequirements")]
        public async Task<ActionResult<ApiResponse>> CalculateNutritionRequirements(NutritionCalculatorRequestModel model)
        {

            var response = await _nutritionService.NutritionCalculator(model);
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
