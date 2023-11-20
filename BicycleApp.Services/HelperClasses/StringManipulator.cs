namespace BicycleApp.Services.HelperClasses
{
    using BicycleApp.Services.HelperClasses.Contracts;

    public class StringManipulator : IStringManipulator
    {
        public string? GetTextFromProperty(string? text)
        {
            return string.IsNullOrEmpty(text) ? string.Empty : text;
        }
    }
}
