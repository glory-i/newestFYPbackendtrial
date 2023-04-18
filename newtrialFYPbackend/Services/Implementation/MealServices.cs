using AutoMapper;
using newtrialFYPbackend.Authentication;
using newtrialFYPbackend.DTOs.MealDTOs;
using newtrialFYPbackend.Model.NutritionModels;
using newtrialFYPbackend.Repository.Interface;
using newtrialFYPbackend.Responses;
using newtrialFYPbackend.Services.Interface;
using System.IO;
using System;
using System.Threading.Tasks;
using newtrialFYPbackend.Utilities;
using newtrialFYPbackend.Model;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace newtrialFYPbackend.Services.Implementation
{
    public class MealServices : IMealServices
    {
        private readonly IMealRepository _mealRepository;
        public MealServices(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        
        public string getImageId(string imageUrl)
        {
            //return the id of the image passed from the google drive
            var imageUrlList = imageUrl.Split('/').ToList();
            return imageUrlList[5];
        }

        public string getFlutterImageFormat(string imageId)
        {
            //return the url of the image from the google drive in a url that flutter can consume.
            return  $"https://drive.google.com/uc?export=view&id={imageId}";

        }


        public async Task<ApiResponse> createMeal(createMealDTO model)
        {
            ReturnedResponse returnedResponse = new ReturnedResponse();

            if(model.imageUrl != null)
            {
                var mapper = new Mapper(MapperConfig.GetMapperConfiguration());
                var meal = mapper.Map<Meal>(model);
                meal.flutterImageUrl = getFlutterImageFormat(getImageId(model.imageUrl));

                meal = await _mealRepository.createMeal(meal);
                if (meal == null)
                {
                    return returnedResponse.ErrorResponse("Could not create food", null);
                }

                return returnedResponse.CorrectResponse(meal);

            }

            else
            {
                return returnedResponse.ErrorResponse("No Image For this meal was provided.", null);
            }

        }
    }
}
