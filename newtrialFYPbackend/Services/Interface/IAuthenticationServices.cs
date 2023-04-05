﻿using newtrialFYPbackend.Authentication;
using newtrialFYPbackend.Responses;
using System.Threading.Tasks;

namespace newtrialFYPbackend.Services.Interface
{
    public interface IAuthenticationServices
    {
        public  Task<ApiResponse> RegisterUser(ValidateModel model);
        public  Task<ApiResponse> SignUpUser(SignUpModel model);
        public  Task<ApiResponse> UpdateUser(string username, UpdateUserModel model);
        public  Task<ApiResponse> ViewUser(string username);
        public  Task<ApiResponse> Login(LoginModel model);
        public  Task<ApiResponse> CheckValidations(ValidateModel model);
        public  ApiResponse ValidatePassword(string password);

        public Task<ApiResponse> ValidateUserExists(string email);


        public  Task<bool> ValidateEmail(string email);
        public  bool ValidateEmailRegExp(string email);



        public Task<ApiResponse> CreateOTP(string username, string email);
        public Task<ApiResponse> SendOTP(string username, string email);
        public Task<ApiResponse> ValidateOTP(int inputPin, string username, string email);





        public Task<double> CalculateHeight(double feet, double inches);
        public Task<double> CalculateBMR(CalculateCalorieRequirementsModel model);
        public Task<double> CalculateAMR(CalculateCalorieRequirementsModel model);
        public Task<double> CalculateCalorieRequirements(CalculateCalorieRequirementsModel model);
        public int AssignActivityLevel(string activityLevel);


        public Task<ApiResponse> ForgotPassword(string email, string newPassword, string confirmPassword);
        public Task<ApiResponse> ChangePassword(string username, string currentPassword, string newPassword, string confirmPassword);

    }
}
