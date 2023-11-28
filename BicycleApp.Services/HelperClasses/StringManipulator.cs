namespace BicycleApp.Services.HelperClasses
{
    using BicycleApp.Services.HelperClasses.Contracts;
    using System.Text;

    public class StringManipulator : IStringManipulator
    {
        public string? GetTextFromProperty(string? text)
        {
            return string.IsNullOrEmpty(text) ? string.Empty : text;
        }

        public string ReturnFullName(string firstName, string lastName)
        {
            var fullname = new StringBuilder();
            fullname.Append(firstName);
            fullname.Append(" ");
            fullname.Append(lastName);

            return fullname.ToString();
        }

        public string UrlMaker(string httpScheme, string httpHost, string endPoint, string? values)
        {
            return $"{httpScheme}://{httpHost}/{endPoint}?{values}";
        }
    }
}
