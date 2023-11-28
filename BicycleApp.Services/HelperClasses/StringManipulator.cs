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
                int randomCharIndex = random.Next(0, allowedChars.Length + 1);
                serialNumber.Append(allowedChars[randomCharIndex]);
            }

            return serialNumber.ToString();
        }
    }
}
