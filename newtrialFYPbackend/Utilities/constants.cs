namespace newtrialFYPbackend.Utilities
{
    public static class NutritionalConstants
    {
        public static double carbsToCalories = 4.0; 
        public static double proteinToCalories = 4.0; 
        public static double fatToCalories = 9.0;



        /// <summary>
        /// ALL VALUES HERE ARE SUBJECT TO CHANGE BASED ON RESEARCH
        /// </summary>
        public static double minPercentCaloriesFromCarbs = 10.0;
        public static double maxPercentCaloriesFromCarbs = 35.0;

        public static double minPercentCaloriesFromProteins = 45.0;
        public static double maxPercentCaloriesFromProteins = 65.0;

        public static double minPercentCaloriesFromFats = 30.0;
        public static double maxPercentCaloriesFromFats = 40.0;


    }

    public static class ImageConstants
    {
        public static string jpgImageData = "data:image/jpg;base64,";
    }
}
