namespace BicycleApp.Services.HelperClasses
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using System.Text;

    public class StringManipulator : IStringManipulator
    {
        private readonly IOptionProvider _optionProvider;
        public StringManipulator(IOptionProvider optionProvider)
        {
            _optionProvider = optionProvider;
        }

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
        public string UrlImageMaker(string httpScheme, string httpHost, string httpPathBase, string endPoint)
        {
            string imageRelativePath = string.Empty;

            if (endPoint == null)
            {
                endPoint = _optionProvider.GetDefaultAvatarRelativePath();
            }

            imageRelativePath = endPoint.Replace("\\", "/");

            return httpScheme + "://" + httpHost + httpPathBase + "/" + imageRelativePath;
        }
        public string UrlMaker(string httpScheme, string httpHost, string endPoint, string? values)
        {
            return $"{httpScheme}://{httpHost}/{endPoint}?{values}";
        }

        /// <summary>
        /// Generator of serial number.
        /// </summary>
        /// <returns>string</returns>
        public string SerialNumberGenerator()
        {
            StringBuilder serialNumber = new StringBuilder("BID");
            int numberOfrandoms = 7;

            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random random = new Random();

            for (int i = 0; i <= numberOfrandoms; i++)
            {
                int randomCharIndex = random.Next(0, allowedChars.Length);
                serialNumber.Append(allowedChars[randomCharIndex]);
            }

            return serialNumber.ToString();
        }
        public string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
