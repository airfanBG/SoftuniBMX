namespace BicycleApp.Services.HelperClasses.Contracts
{
    public interface IStringManipulator
    {  
        string? GetTextFromProperty(string? text);
        string ReturnFullName(string firstName, string lastName);
    }
}
