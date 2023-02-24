using AutoMapper;

namespace newtrialFYPbackend.Authentication
{
    public class MapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SignUpModel, ValidateModel>();
                cfg.CreateMap<SignUpModel, CalculateCalorieRequirementsModel>();
                cfg.CreateMap<ApplicationUser, LoginResponseModel>();
                cfg.CreateMap<AuthorizationToken, LoginResponseModel>();
            }
                   );
            return config;
        }
    }
}
