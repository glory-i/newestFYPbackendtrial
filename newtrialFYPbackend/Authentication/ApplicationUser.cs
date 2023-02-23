using Microsoft.AspNetCore.Identity;

namespace newtrialFYPbackend.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Weight { get; set; }
        public double Height { get; set; }
        public int ActivityLevel { get; set; }
        public string Goal { get; set; }
        public double CalorieRequirement { get; set; }

    }
}
