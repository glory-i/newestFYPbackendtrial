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
        [Description("Sedentary")] Sedentary = 1,
        [Description("Lightly Active")] LightlyActive = 2,
        [Description("Moderately Active")] ModeratelyActive = 3,
        [Description("Active")] Active = 4,
        [Description("Very Active")] VeryActive = 5,
    }
}
