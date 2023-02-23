using newtrialFYPbackend.Authentication;
using newtrialFYPbackend.Responses;
using System.Threading.Tasks;

namespace newtrialFYPbackend.Services.Interface
{
    public interface IAuthenticationServices
    {
        public  Task<ApiResponse> RegisterUser(ValidateModel model);
        public  Task<ApiResponse> SignUpUser(SignUpModel model);
        public  Task<ApiResponse> CheckValidations(ValidateModel model);
        public  ApiResponse ValidatePassword(string password);

        
        public  Task<bool> ValidateEmail(string email);
        public  bool ValidateEmailRegExp(string email);

        public Task<ApiResponse> CreateOTP(string username, string email);
        public Task<ApiResponse> SendOTP(string username, string email);
        public Task<ApiResponse> ValidateOTP(int inputPin, string username, string email);



        public Task<double> CalculateHeight(double h1, double h2, string unit);
        public Task<double> CalculateBMR(CalculateCalorieRequirementsModel model);
        public Task<double> CalculateAMR(CalculateCalorieRequirementsModel model);
        public Task<double> CalculateCalorieRequirements(CalculateCalorieRequirementsModel model);
        public int AssignActivityLevel(string activityLevel);



    }
}
