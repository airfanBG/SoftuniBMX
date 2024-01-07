namespace BicycleApp.Services.HelperClasses.Contracts
{
    public interface IStringManipulator
    {  
        string? GetTextFromProperty(string? text);
        string ReturnFullName(string firstName, string lastName);
        string UrlImageMaker(string httpScheme, string httpHost, string httpPathBase, string endPoint);
        string UrlMaker(string httpScheme, string httpHost, string endPoint, string? values);
        string SerialNumberGenerator();
        string CreateGuid();
    }
}
