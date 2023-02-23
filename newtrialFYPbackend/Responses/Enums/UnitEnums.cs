using System.ComponentModel;

namespace newtrialFYPbackend.Responses.Enums
{
    public enum HeightUnitEnum
    {
        [Description("feet")] feet = 1,
        [Description("meters")] meters,
    }

    public enum GenderEnum
    {
        [Description("Male")] Male = 1,
        [Description("Female")] Female,
    }


    public enum GoalEnum
    {
        [Description("Lose Weight")] Lose = 1,
        [Description("Gain Weight")] Gain = 2,
        [Description("Maintain Weight")] Maintain = 3,
    }

    public enum ActivityLevelEnum
    {
        [Description("Little or no exercise weekly")] Sedentary = 1,
        [Description("Light exercise 1-3 days per week")] LightlyActive = 2,
        [Description("Moderate exercise 6/7 days per week")] ModeratelyActive = 3,
        [Description("Hard exercise every day in a week")] Active = 4,
        [Description("Hard exercise two or more times per day")] VeryActive = 5,
    }
}
